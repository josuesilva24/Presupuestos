$(document).ready(function () {
    pageSetUp();
    function SinTipoCuenta(cellvalue, options, rowObject) {
        // do something here
        return cellvalue == "" ? "" : cellvalue;
    }
    jQuery("#jqgrid").jqGrid({
        url: 'getCuentaContable',
        //  editurl: 'clientArray',
        datatype: "json",
        height: 'auto',
        colNames: ['', 'IdBD','Codigo', 'Descripción', 'TipoCuenta'],
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
                   name: 'Codigo',
                   index: 'Codigo',
                   editable: false,
               },
        {
            name: 'Descripcion',
            index: 'Descripcion',
            editable: false
        },
        {
            name: 'TipoCuenta',
            index: 'TipoCuenta',
            align: "center",
            editable: true,
            formatter: SinTipoCuenta,
            edittype: "select",
            editoptions: {
                dataUrl: "getTipoCuentaContable",
                cacheUrlData: false,
                buildSelect: function (data) {

                    var result = JSON.parse(data);
                    var $select = "<select>";
                    for (var i = 0; i < result.length; i++) {
                        $select += '<option value="' + result[i].id + '">' + result[i].Descripcion + '</option>';
                    }

                    return $select + "</select>";
                }
            }
        }],
        rowNum: 10,
        rowList: [10, 20, 30],
        pager: '#pjqgrid',
        sortname: 'id',
        toolbarfilter: true,
        viewrecords: true,
        sortorder: "asc",
        editurl: 'updateCuentaContable',
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
        caption: "Cuentas Contables",
        multiselect: false,
        autowidth: true,
        loadError: function (jqXHR, textStatus, errorThrown) {
            alert(errorThrown);
        },
        Success: function (result) {
            alert(result);
        },
        loadonce: true

    });
    jQuery("#jqgrid").jqGrid('navGrid', "#pjqgrid", {
        edit: false,
        add: false,
        del: false,
        search: false

    });
    $('#jqgrid').jqGrid('filterToolbar', { stringResult: true, searchOnEnter: false, ignoreCase: true, defaultSearch: 'cn' });

    jQuery("#jqgrid").jqGrid('inlineNav', "#pjqgrid", {
        edit: true,
        add: false,
        del: false,
        editParams: function (val) {
            if (!val) {
                messageError("Error al guardar la información");
                reloadGrid('jqgrid', 'getCuentaContable')
            }
            else {
                messageExitoso("Información guardada correctamente!");
                reloadGrid('jqgrid', 'getCuentaContable')
            }
        }
    });
    $("#jqgrid pgbuttons").removeClass("ui-state-disabled")
    /* Add tooltips */
    $('.navtable .ui-pg-button').tooltip({
        container: 'body'
    });

    jQuery("#m1").click(function () {
        var s;
        s = jQuery("#jqgrid").jqGrid('getGridParam', 'selarrrow');
        alert(s);
    });
    jQuery("#m1s").click(function () {
        jQuery("#jqgrid").jqGrid('setSelection', "13");
    });


    AddClasesGrid();
    jqgriAdd();

})

