$(function () {
    jQuery("#RightAccordion").accordion({ //初始化accordion
        fillSpace: true,
        fit: true,
        border: false,
        animate: false
    });
    $('#RightAccordion').accordion('add', {
        title: '系统管理',
        content: "<p>Accordion is a part of easyui framework for jQuery. It lets you define your accordion component on web page more easily.</p>",
        selected: true,
        iconCls: 'icon-ok'
    });
    $('#RightAccordion').accordion('add', {
        title: '帮助',
        content: "<p>Accordion is a part of easyui framework for jQuery. It lets you define your accordion component on web page more easily.</p>",
        selected: false,
        iconCls: 'icon-help'
    });
    $('#RightAccordion').accordion('add', {
        title: '系统菜单',
        content: "<p>Accordion is a part of easyui framework for jQuery. It lets you define your accordion component on web page more easily.</p>",
        selected: false,
        iconCls: 'icon-search'
    });
    $.parser.parse();
});