$(document).ready(function () {
    pageSetUp();

    jQuery("#jqgrid").jqGrid({
        url: 'getProyeccionGastos',
        //  editurl: 'clientArray',
        datatype: "json",
        height: 'auto',
        colNames: ['', 'Cuenta Contable','Centro de costo', 'Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
        colModel: [{
            name: 'act',
            index: 'act',
            sortable: false,
            search: false,
            hidden: true

        },


        {
            name: 'CuentaContable',
            index: 'CuentaContable',
            editable: true,
            search: false

        },
            {
                name: 'CentroCosto',
                index: 'CentroCosto',
                editable: true,
                search: false

            },
          {
              name: 'Enero',
              index: 'Enero',
              search: false,
              editable: true,
              formatter: 'number',
          }, {
              name: 'Febrero',
              index: 'Febrero',
              search: false,
              editable: true,
              formatter: 'number',
          }, {
              name: 'Marzo',
              index: 'Marzo',
              search: false,
              editable: true,
              formatter: 'number',

          }, {
              name: 'Abril',
              index: 'Abril',
              search: false,
              editable: true,
              formatter: 'number',

          }, {
              name: 'Mayo',
              index: 'Mayo',
              search: false,
              editable: true,
              formatter: 'number',

          }, {
              name: 'Junio',
              index: 'Junio',
              search: false,
              editable: true,
              formatter: 'number',

          }, {
              name: 'Julio',
              index: 'Julio',
              search: false,
              editable: true,
              formatter: 'number',

          }, {
              name: 'Agosto',
              index: 'Agosto',
              search: false,
              editable: true,
              formatter: 'number',

          }, {
              name: 'Septiembre',
              index: 'Septiembre',
              search: false,
              editable: true,
              formatter: 'number',

          }, {
              name: 'Octubre',
              index: 'Octubre',
              search: false,
              editable: true,
              formatter: 'number',

          }, {
              name: 'Noviembre',
              index: 'Noviembre',
              search: false,
              editable: true,
              formatter: 'number',

          }, {
              name: 'Diciembre',
              index: 'Diciembre',
              search: false,
              editable: true,
              formatter: 'number',

          },
        ],
        rowNum: 10,
        rowList: [10, 20, 30],
        pager: '#pjqgrid',
        sortname: 'id',
        toolbarfilter: true,
        viewrecords: true,
        sortorder: "asc",
        editurl: '',
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
        caption: "Tipo de cambio",
        multiselect: false,
        autowidth: true,
        loadError: function (jqXHR, textStatus, errorThrown) {
            alert(errorThrown);
        },
        Success: function (result) {
            alert(result);
        },

    });
    jQuery("#jqgrid").jqGrid('navGrid', "#pjqgrid", {
        edit: false,
        add: false,
        del: false,
        search: false

    });
    $('#jqgrid').jqGrid('filterToolbar', { stringResult: true, searchOnEnter: false });

    jQuery("#jqgrid").jqGrid('inlineNav', "#pjqgrid", {
        edit: true,
        add: true,
        del: false,
        editParams: function (val) {
            if (!val) {
                alert(val.responseText);
                var grid = $('#jqgrid');
                grid.trigger('reloadGrid');
                grid.jqGrid('setGridParam', { url: 'getProyeccionGastos', datatype: "json", }).trigger("reloadGrid");


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
        s = jQuery("#jqgrid").jqGrid('getGridParam', 'selarrrow');
        alert(s);
    });
    jQuery("#m1s").click(function () {
        jQuery("#jqgrid").jqGrid('setSelection', "13");
    });
    jQuery("#Verdatos").click(function () {
        mostrarDatos();
    });

    

    function mostrarDatos() {
        var grid = $('#jqgrid');
        grid.trigger('reloadGrid');
        grid.jqGrid('setGridParam', { url: '..PPGastos\getProyeccionGastos', datatype: "json", }).trigger("reloadGrid");
    }



    AddClasesGrid()
    jqgriAdd();
 

})



