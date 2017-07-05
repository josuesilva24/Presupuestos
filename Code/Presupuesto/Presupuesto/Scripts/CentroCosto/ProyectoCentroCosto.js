$(document).ready(function () {
    pageSetUp();

    ListaCentrosCostoCombo();


    function ToActivoInactivo(cellvalue, options, rowObject) {
        // do something here
        return cellvalue == true ? "Activo" : "Inactivo";
    }

    $("#jqgridPCC").jqGrid({
        url: 'getProyectosCentrosCosto',
        editurl: 'clientArray',
        datatype: "json",
        height: 'auto',
        colNames: ['', 'IdBD', 'Descripción', 'Código', 'Estado', 'CentroCosto'],
        colModel: [{
            name: 'act',
            index: 'act',
            sortable: false,
            search: false,
            hidden: true

        },
           {
               name: 'IdBD',
               index: 'IdBD',
               editable: true,
               hidden: true
           },
        {
            name: 'Descripcion',
            index: 'Descripcion',
            editable: true
        }, {
            name: 'Codigo',
            index: 'Codigo',
            editable: false
        }, {
            name: 'Estado',
            index: 'Estado',
            align: "center",
            editable: true,
            edittype: "select",
            formatter: ToActivoInactivo,
            editoptions: {
                value: "true:Activo;false:Inactivo",
            },
            search: false

        }, {
            name: 'CentroCosto',
            index: 'CentroCosto',
            editable: true,
            search: true,
            edittype: 'select',
            editoptions: {
                dataUrl: "getCentrosCostoList",
                cacheUrlData: false,
                buildSelect: function (data) {

                    var result = JSON.parse(data);
                    var $select = "<select>";
                    for (var i = 0; i < result.length; i++) {
                        $select += '<option value="' + result[i].Value + '">' + result[i].Text + '</option>';
                    }

                    return $select +"</select>";

                    //var dataa = data, i = 0, s = '<select>', d;
        
                    //    for (var i = 0; i < result.length; i++) {
                    //        $('#CentroCostoList').append('<option value="' + result[i].Value + '">' + result[i].Text + '</option>');
                    //}
                    //s += '</select>';
                    //return s;
                }
            }

        }, ],
        rowNum: 10,
        rowList: [10, 20, 30],
        pager: '#pjqgridPCC',
        sortname: 'id',
        toolbarfilter: true,
        viewrecords: true,
        sortorder: "asc",
        editurl: 'updateProyectoCentroCosto',
        gridComplete: function () {
            //var ids = jQuery("#jqgrid").jqGrid('getDataIDs');
            //for (var i = 0; i < ids.length; i++) {
            //    var cl = ids[i];
            //    be = "<button class='btn btn-xs btn-default' data-original-title='Edit Row' onclick=\"jQuery('#jqgrid').editRow('" + cl + "');\"><i class='fa fa-pencil'></i></button>";
            //    se = "<button class='btn btn-xs btn-default' data-original-title='Save Row' onclick=\"jQuery('#jqgrid').saveRow('" + cl + "'); \"><i class='fa fa-save'></i></button>";
            //    ca = "<button class='btn btn-xs btn-default' data-original-title='Cancel' onclick=\"jQuery('#jqgrid').restoreRow('" + cl + "');\"><i class='fa fa-times'></i></button>";
            //    ce = "<button class='btn btn-xs btn-default' onclick=\"jQuery('#jqgrid').restoreRow('"+cl+"');\"><i class='fa fa-times'></i></button>";
            //jQuery("#jqgrid").jqGrid('setRowData',ids[i],{act:be+se+ce});
            //jQuery("#jqgrid").jqGrid('setRowData', ids[i], {
            //    act : be + se + ca
            //});
            //  }
        },
        caption: "Centros de costos",
        multiselect: false,
        autowidth: true,
        loadError: function (jqXHR, textStatus, errorThrown) {
            alert(errorThrown);
        },
        Success: function (result) {
            alert(result);
        },

    });
    jQuery("#jqgridPCC").jqGrid('navGrid', "#pjqgridPCC", {
        edit: false,
        add: false,
        del: false,
        search: false

    });
    $('#jqgridPCC').jqGrid('filterToolbar', { stringResult: true, searchOnEnter: false });

    jQuery("#jqgridPCC").jqGrid('inlineNav', "#pjqgridPCC", {
        edit: true,
        add: true,
        del: false,
        editParams: function (val) {
            if (!val) {
                alert(val.responseText);
                var grid = $('#jqgridPCC');
                grid.trigger('reloadGrid');
                grid.jqGrid('setGridParam', { url: 'getCentrosCosto', datatype: "json", }).trigger("reloadGrid");


            }
            else {
                alert("Centro de costo actualizado correctamente");
            }
        }
    });

    /* Add tooltips */
    $('.navtable .ui-pg-button').tooltip({
        container: 'body'
    });

    jQuery("#m1").click(function () {
        var s;
        s = jQuery("#jqgridPCC").jqGrid('getGridParam', 'selarrrow');
        alert(s);
    });
    jQuery("#m1s").click(function () {
        jQuery("#jqgridPCC").jqGrid('setSelection', "13");
    });


    $("#CentroCostoList").change(function(){
        var val = $(this).val();
        updateGrid(val);
    });
    // remove classes
    $(".ui-jqgrid").removeClass("ui-widget ui-widget-content");
    $(".ui-jqgrid-view").children().removeClass("ui-widget-header ui-state-default");
    $(".ui-jqgrid-labels, .ui-search-toolbar").children().removeClass("ui-state-default ui-th-column ui-th-ltr");
    $(".ui-jqgrid-pager").removeClass("ui-state-default");
    $(".ui-jqgrid").removeClass("ui-widget-content");

    // add classes
    $(".ui-jqgrid-htable").addClass("table table-bordered table-hover");
    $(".ui-jqgrid-btable").addClass("table table-bordered table-striped");

    $(".ui-pg-div").removeClass().addClass("btn btn-sm btn-primary");
    $(".ui-icon.ui-icon-plus").removeClass().addClass("fa fa-plus");
    $(".ui-icon.ui-icon-pencil").removeClass().addClass("fa fa-pencil");
    $(".ui-icon.ui-icon-trash").removeClass().addClass("fa fa-trash-o");
    $(".ui-icon.ui-icon-search").removeClass().addClass("fa fa-search");
    $(".ui-icon.ui-icon-refresh").removeClass().addClass("fa fa-refresh");
    $(".ui-icon.ui-icon-disk").removeClass().addClass("fa fa-save").parent(".btn-primary").removeClass("btn-primary").addClass("btn-success");
    $(".ui-icon.ui-icon-cancel").removeClass().addClass("fa fa-times").parent(".btn-primary").removeClass("btn-primary").addClass("btn-danger");

    $(".ui-icon.ui-icon-seek-prev").wrap("<div class='btn btn-sm btn-default'></div>");
    $(".ui-icon.ui-icon-seek-prev").removeClass().addClass("fa fa-backward");

    $(".ui-icon.ui-icon-seek-first").wrap("<div class='btn btn-sm btn-default'></div>");
    $(".ui-icon.ui-icon-seek-first").removeClass().addClass("fa fa-fast-backward");

    $(".ui-icon.ui-icon-seek-next").wrap("<div class='btn btn-sm btn-default'></div>");
    $(".ui-icon.ui-icon-seek-next").removeClass().addClass("fa fa-forward");

    $(".ui-icon.ui-icon-seek-end").wrap("<div class='btn btn-sm btn-default'></div>");
    $(".ui-icon.ui-icon-seek-end").removeClass().addClass("fa fa-fast-forward");

})

$(window).on('resize.jqGrid', function () {
    $("#jqgridPCC").jqGrid('setGridWidth', $("#content").width());
})


var _gaq = _gaq || [];
_gaq.push(['_setAccount', 'UA-XXXXXXXX-X']);
_gaq.push(['_trackPageview']);

(function () {
    var ga = document.createElement('script');
    ga.type = 'text/javascript';
    ga.async = true;
    ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
    var s = document.getElementsByTagName('script')[0];
    s.parentNode.insertBefore(ga, s);
})();


function ListaCentrosCostoCombo() {
    $.ajax({
        url: "getCentrosCostoList",
        cache: false,
        success: function (result) {
            for (var i = 0; i < result.length; i++) {
                $('#CentroCostoList').append('<option value="' + result[i].Value + '">' + result[i].Text + '</option>');
            }
            //$("#CentroCostoList option[value=" + $("#AduanaControlHidden").val() + "]").prop('selected', true);

        }
    });
}

function updateGrid(CodigoCentroCosto)
{
    var grid = $('#jqgridPCC');
    grid.jqGrid('clearGridData');
    grid.jqGrid('setGridParam', { url: 'getProyectosPorCentrosCosto?codigo=' + CodigoCentroCosto, datatype: "json", }).trigger("reloadGrid");

}
