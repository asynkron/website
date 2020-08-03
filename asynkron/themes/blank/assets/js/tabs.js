let tabId = 0;
$(document).ready(function () {

    $('.tab-content').find('.tab-pane').each(function (idx, item) {

        var navTabs = $(this).closest('.code-tabs').find('.nav-tabs');
        title = $(this).attr('title') + tabId;
        $(this).attr("id","tab" + tabId);
        navTabs.append('<li class="nav-item"><a class="nav-link" data-toggle="tab" role="tab" aria-selected="false" href="#tab'+tabId+'" aria-controls="tab' + tabId + '" >' + title + '</a></li');
        
        tabId++;
    });
});