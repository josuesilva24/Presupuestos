$(document).ready(function () {
    pageSetUp();
    function ToActivoInactivo(cellvalue, options, rowObject) {
        // do something here
        return cellvalue == true ? "Activo" : "Inactivo";
    }
    jQuery("#jqgrid").jqGrid({
        url: 'getMoneda',
        //  editurl: 'clientArray',
        datatype: "json",
        height: 'auto',
        colNames: ['', 'IdBD', 'Código', 'Descripción', 'Estado'],
        colModel: [{
            name: 'act',
            index: 'act',
            sortable: false,
            search: false,
            hidden: true

        },
           {
               name: 'id',
               index: 'id',
               editable: true,
               hidden: true
           },
        {
            name: 'Nombre',
            index: 'Nombre',
            editable: true,
            search: false,
            hidden: false
        },
        {
            name: 'Descripcion',
            index: 'Descripcion',
            editable: true,
            search: false

        },
          {
              name: 'Activo',
              index: 'Activo',
              search: false,
              editable: true,
              formatter: ToActivoInactivo,
              edittype: "select",
              editoptions: {
                  value: "True:Activo;False:Inactivo",
              },
              search: false
          },
        ],
        rowNum: 10,
        rowList: [10, 20, 30],
        pager: '#pjqgrid',
        sortname: 'id',
        toolbarfilter: true,
        viewrecords: true,
        sortorder: "asc",
        editurl: 'updateMoneda',
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
        caption: "Monedas",
        multiselect: false,
        autowidth: true,
        toolbarfilter: true,
        loadError: function (jqXHR, textStatus, errorThrown) {
            alert(errorThrown);
        },
        loadonce: true,
        afterSubmit: function (response, postdata) {
            if (!response) {
                messageError("Error al guardar la información");
                reloadGrid('jqgrid', 'getMoneda');
            }
            else {
                messageExitoso("Moneda actualizada correctamente!");
                reloadGrid('jqgrid', 'getMoneda');
            }
        }

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
        add: function (val) { alert('test')} ,
        del: false,
        editParams: function (val) {
            if (!val) {
                messageError("Error al guardar la información");
                reloadGrid('jqgrid', 'getMoneda');
            }
            else {
                messageExitoso("Moneda actualizada correctamente!");
                reloadGrid('jqgrid', 'getMoneda');
            }
        },
        //addRowParams: {
        //    // here are editOption used for Add
        //    keys: true,
        //    successfunc:  reloadGrid('jqgrid', 'getMoneda'),
        //    extraparam: {
        //        userId: function () {
        //            return currentUserId;
        //        },
        //        companyId: function () {
        //            return currentCompanyId;
        //        }
        //    }
        //}                        
    });

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



    // remove classes
    AddClasesGrid();
    jqgriAdd();
})


