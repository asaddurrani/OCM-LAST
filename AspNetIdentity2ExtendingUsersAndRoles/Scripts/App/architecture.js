﻿// Global Variable
var ist = {
    datePattern: "DD/MM/YY",
    timePattern: "HH:mm",
    dateTimePattern: "DD/MM/YY HH:mm",
    dateTimeWithSecondsPattern: "DD/MM/YY HH:mm:ss",
    // UTC Date Format
    utcFormat: "YYYY-MM-DDTHH:mm:ss",
    //server exceptions enumeration 
    exceptionType: {
        UserException: 1,
        UnspecifiedException: 2
    },
    //verify if the string is a valid json
    verifyValidJSON: function (str) {
        try {
            JSON.parse(str);
        }
        catch (exception) {
            return false;
        }
        return true;
    },
    // Validate Url
    validateUrl: function (field) {
        var regex = /^(?:(?:https?|ftp):\/\/)(?:\S+(?::\S*)?@)?(?:(?!10(?:\.\d{1,3}){3})(?!127(?:\.\d{1,3}){3})(?!169\.254(?:\.\d{1,3}){2})(?!192\.168(?:\.\d{1,3}){2})(?!172\.(?:1[6-9]|2\d|3[0-1])(?:\.\d{1,3}){2})(?:[1-9]\d?|1\d\d|2[01]\d|22[0-3])(?:\.(?:1?\d{1,2}|2[0-4]\d|25[0-5])){2}(?:\.(?:[1-9]\d?|1\d\d|2[0-4]\d|25[0-4]))|(?:(?:[a-z\u00a1-\uffff0-9]+-?)*[a-z\u00a1-\uffff0-9]+)(?:\.(?:[a-z\u00a1-\uffff0-9]+-?)*[a-z\u00a1-\uffff0-9]+)*(?:\.(?:[a-z\u00a1-\uffff]{2,})))(?::\d{2,5})?(?:\/[^\s]*)?$/i;
        return (regex.test(field)) ? true : false;
    }
};

// Busy Indicator
var spinnerVisibleCounter = 0;

// Show Busy Indicator
function showProgress() {
    ++spinnerVisibleCounter;
    if (spinnerVisibleCounter > 0) {
        $("div#spinner").fadeIn("fast");
    }
};

// Hide Busy Indicator
function hideProgress() {
    --spinnerVisibleCounter;
    if (spinnerVisibleCounter <= 0) {
        spinnerVisibleCounter = 0;
        var spinner = $("div#spinner");
        spinner.stop();
        spinner.fadeOut("fast");
    }
};


// Amplify Decoders
//status decoder for parsing the exception type and message
amplify.request.decoders = {
    odyStatusDecoder: function (data, status, xhr, success, error) {
        if (status === "success") {
            success(data);
        } else {
            if (status === "fail" || status === "error") {
                var errorObject = {};
                errorObject.errorType = ody.exceptionType.UnspecifiedException;
                if (ody.verifyValidJSON(xhr.responseText)) {
                    errorObject.errorDetail = JSON.parse(xhr.responseText);;
                    if (errorObject.errorDetail.ErrorCode) {
                        errorObject.errorType = ody.exceptionType.UserException;
                    }
                }
                error(xhr.responseText, errorObject);
            } else {
                error(xhr.responseText, "fatal");
            }
        }
    }
};

// If while ajax call user shifts to another page then avoid error toasts
amplify.subscribe("request.before.ajax", function (resource, settings, ajaxSettings, ampXhr) {
    var _error = ampXhr.error;

    function error(data, status) {
        _error(data, status);
    }

    ampXhr.error = function (data, status) {
        if (ampXhr.status === 0) {
            return;
        }
        error(data, status);
    };

});

// Knockout Validation + Bindings

var ko = window["ko"];

require(["ko", "knockout-validation"], function (ko) {
    ko.utils.stringStartsWith = function (string, startsWith) {
        string = string || "";
        if (startsWith.length > string.length)
            return false;
        return string.substring(0, startsWith.length) === startsWith;
    };
    // jquery date picker binding. Usage: <input data-bind="datepicker: myDate, datepickerOptions: { minDate: new Date() }" />. Source: http://jsfiddle.net/rniemeyer/NAgNV/
    ko.bindingHandlers.datepicker = {
        init: function (element, valueAccessor, allBindingsAccessor) {
            //initialize datepicker with some optional options
            // ReSharper disable DuplicatingLocalDeclaration
            var options = allBindingsAccessor().datepickerOptions || {};
            // ReSharper restore DuplicatingLocalDeclaration
            $(element).datepicker(options);
            $(element).datepicker("option", "dateFormat", options.dateFormat || ist.customShortDatePattern);
            //handle the field changing
            ko.utils.registerEventHandler(element, "change", function () {
                var observable = valueAccessor();
                observable($(element).datepicker("getDate"));
            });

            //handle disposal (if KO removes by the template binding)
            ko.utils.domNodeDisposal.addDisposeCallback(element, function () {
                $(element).datepicker("destroy");
            });

        },
        update: function (element, valueAccessor) {
            var observable = valueAccessor();

            var value = ko.utils.unwrapObservable(valueAccessor()),
                current = $(element).datepicker("getDate");

            if (value - current !== 0) {
                $(element).datepicker("setDate", value);
            }
            //For showing highlighted field if contains invalid value
            if (observable.isValid) {
                if (!observable.isValid() && observable.isModified()) {
                    $(element).addClass('errorFill');
                } else {
                    $(element).removeClass('errorFill');
                }
            }
        }
    };
    // jquery date time picker binding. Usage: <input data-bind="datetimepicker: myDate, datepickerOptions: { minDate: new Date() }" />. Source: http://jsfiddle.net/rniemeyer/NAgNV/
    ko.bindingHandlers.datetimepicker = {
        init: function (element, valueAccessor, allBindingsAccessor) {
            //initialize datepicker with some optional options
            // ReSharper disable DuplicatingLocalDeclaration
            var options = allBindingsAccessor().datepickerOptions || {};
            // ReSharper restore DuplicatingLocalDeclaration
            $(element).datetimepicker(options);
            $(element).datetimepicker("option", "dateFormat", options.dateFormat || ist.customShortDatePattern);
            //handle the field changing
            ko.utils.registerEventHandler(element, "change", function () {
                var observable = valueAccessor();
                observable($(element).datetimepicker("getDate"));
            });

            //handle disposal (if KO removes by the template binding)
            ko.utils.domNodeDisposal.addDisposeCallback(element, function () {
                $(element).datetimepicker("destroy");
            });

        },
        update: function (element, valueAccessor) {
            var observable = valueAccessor();

            var value = ko.utils.unwrapObservable(valueAccessor()),
                current = $(element).datetimepicker("getDate");

            if (value - current !== 0) {
                $(element).datetimepicker("setDate", value);
            }
            //For showing highlighted field if contains invalid value
            if (observable.isValid) {
                if (!observable.isValid() && observable.isModified()) {
                    $(element).addClass('errorFill');
                } else {
                    $(element).removeClass('errorFill');
                }
            }
        }
    };
    ko.bindingHandlers.validationDependsOn = {
        update: function (element, valueAccessor) {
            var observable = valueAccessor();

            if (observable.isValid) {
                if (!observable.isValid() && observable.isModified()) {
                    $(element).addClass('errorFill');
                } else {
                    $(element).removeClass('errorFill');
                }
            }
        }
    };
    
    // date formatting. Example <div class="date" data-bind="dateString: today, datePattern: 'dddd, MMMM dd, yyyy'">Thursday, April 05, 2012</div>
    ko.bindingHandlers.dateString = {
        update: function (element, valueAccessor, allBindingsAccessor) {
            var value = valueAccessor(),
                allBindings = allBindingsAccessor();
            var valueUnwrapped = ko.utils.unwrapObservable(value);
            var pattern = allBindings.datePattern || ody.datePattern;
            if (valueUnwrapped !== undefined && valueUnwrapped !== null) {
                $(element).text(moment(valueUnwrapped).format(pattern));
            }
            else {
                $(element).text("");
            }

        }
    };


    //Custom binding for handling validation messages in tooltip
    ko.bindingHandlers.validationTooltip = {
        update: function (element, valueAccessor) {
            var observable = valueAccessor(), $element = $(element);
            if (observable.isValid) {
                if (!observable.isValid() && observable.isModified()) {
                    $element.tooltip({ title: observable.error }); //, delay: { show: 10000, hide: 10000 }
                } else {
                    $element.tooltip('destroy');
                }
            }
        }
    };

    //Custom binding for handling validation messages in tooltip
    ko.bindingHandlers.tooltip = {
        update: function (element, valueAccessor) {
            var $element = $(element);
            var value = ko.utils.unwrapObservable(valueAccessor());
            value = value.replace(/:0/g, ':00');
            $element.tooltip({ title: value, html: true }); //, delay: { show: 10000, hide: 10000 }
        }
    };


    // KO Dirty Flag - Change Tracking
    ko.dirtyFlag = function (root, isInitiallyDirty) {
        var result = function () { },
    // ReSharper disable InconsistentNaming
            _initialState = ko.observable(ko.toJSON(root)),
            _isInitiallyDirty = ko.observable(isInitiallyDirty);
        // ReSharper restore InconsistentNaming

        result.isDirty = ko.dependentObservable(function () {
            return _isInitiallyDirty() || _initialState() !== ko.toJSON(root);
        });

        result.reset = function () {
            _initialState(ko.toJSON(root));
            _isInitiallyDirty(false);
        };

        return result;
    };
    // KO Dirty Flag - Change Tracking

    // Can be used to have a parent with one binding and children with another. Child areas should be surrounded with <!-- ko stopBinding: true --> <!-- /ko -->
    ko.bindingHandlers.stopBinding = {
        init: function () {
            return { controlsDescendantBindings: true };
        }
    };

    ko.virtualElements.allowedBindings.stopBinding = true;

    var options = { insertMessages: false, decorateElement: true, errorElementClass: 'errorFill', messagesOnModified: true, registerExtenders: true };
    ko.validation.init(options);
    
});


// Sorting 
// <Param>tableId - Id of the table like "productTable" </Param>
// <Param>Sort On - Observable, to identify sort column</Param>
// <Param>Sort Asc - Observable, to identify sort Order i.e. Asc, or desc</Param>
// <Param>callback - function, to call for refreshing the list</Param>
function handleSorting(tableId, sortOn, sortAsc, callback) {
    // Make Table Sortable
    $('#' + tableId + ' thead tr th span').bind('click', function (e) {
        if (!e.target || !e.target.id) {
            return;
        }
        var sortBy = e.target.id;
        var targetEl = $(e.target).children("span")[0];
        // Remove other header sorting
        _.each($('.searchFilterResultSection table thead tr th span'), function (item) {
            if (item.parentElement !== e.target) {
                item.className = '';
            }
        });
        // Sort Column
        if (targetEl) {
            var direction = (targetEl.className === 'icon-up') ? 'icon-up' : (targetEl.className === 'icon-down') ? 'icon-down' : 'icon-down';
            if (direction === 'icon-up') {
                targetEl.className = 'icon-down';
                sortAsc(false);
            } else {
                targetEl.className = 'icon-up';
                sortAsc(true);
            }
            sortOn(sortBy);
            
            // Refresh Grid
            if (callback && typeof callback === "function") {
                callback();
            }
        }
    });
}
