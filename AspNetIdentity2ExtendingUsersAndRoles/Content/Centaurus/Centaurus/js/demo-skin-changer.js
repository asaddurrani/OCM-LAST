var storage,fail,uid;try{uid=new Date;(storage=window.localStorage).setItem(uid,uid);fail=storage.getItem(uid)!=uid;storage.removeItem(uid);fail&&(storage=false);}catch(e){}
if (storage) {
    try {
        var usedSkin = localStorage.getItem('config-skin');
        if (usedSkin != '' && usedSkin != null) {
            document.body.className = usedSkin;
        } else {
            //document.body.className = 'theme-blue-gradient';
        }
    } catch(e) {
        //document.body.className = 'theme-blue-gradient';
    }
} else {
     //document.body.className = 'theme-blue-gradient';
}