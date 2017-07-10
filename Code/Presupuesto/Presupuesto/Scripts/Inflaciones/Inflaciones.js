$(document).ready(function () {
    pageSetUp();

    jQuery("#jqgrid").jqGrid({
        url: 'getInflaciones',
        //  editurl: 'clientArray',
        datatype: "json",
        height: 'auto',
        colNames: ['', 'IdBD', 'Año', 'I Semestre', 'II Semestre'],
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
            name: 'Anno',
            index: 'Anno',
            editable: true,
            edittype: 'select',
            search: true,
            editoptions: {
                value: ":;2015:2015;2016:2016;2017:2017;2018:2018;2019:2019;2020:2020;2021:2021;2022:2022;2023:2023;2024:2024;2025:2025;2026:2026;2027:2027;2028:2028;2029:2029;2030:2030",

                dataEvents: [{ type: 'change', fn: function (e) { ValidaAnno($(this).val()); } } ]

            }
        },
        {
            name: 'PrimerSemestre',
            index: 'PrimerSemestre',
            editable: true,
            search: false,
            formatter: 'number',
            number: { decimalSeparator: ".", decimalPlaces: 2, defaultValue: '0.00' },


        },
          {
              name: 'SegundoSemestre',
              index: 'SegundoSemestre',
              search:false,
              editable: true,
              formatter: 'number',
              number: { decimalSeparator: ".", decimalPlaces: 2, defaultValue: '0.00' },

          },
   ],
        rowNum: 10,
        rowList: [10, 20, 30],
        pager: '#pjqgrid',
        sortname: 'id',
        toolbarfilter: true,
        viewrecords: true,
        sortorder: "asc",
        editurl: 'updateInflacion',
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
        caption: "Inflación",
        multiselect: false,
        autowidth: true,
        toolbarfilter: true,
        loadError: function (jqXHR, textStatus, errorThrown) {
            alert(errorThrown);
        },
        loadonce:true,


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
        add: true,
        del: false,
        editParams: function (val) {
            if (!val) {
                messageError("Error al guardar la información");
                reloadGrid('jqgrid', 'getInflaciones');
            }
            else {
                messageExitoso("Información guardada correctamente!");
                reloadGrid('jqgrid', 'getInflaciones')
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

    AddClasesGrid();
    jqgriAdd();

})




function ValidaAnno(Anno) {

        $.ajax({
            url: "getInflacionesPorAnno",
            type: "POST",
            data: JSON.stringify({
                Anno: Anno
            }),
            cache: false,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (result) {
                if (result.length > 0) {
                    messageError("Ya existe un inflación para el año seleccionado, favor seleccione un nuevo año!");
                    $("#jqg1_Anno").val("");
                }
                
            },
            error: function () {
                alert("Error interno");//  $.growl.success({ message: "Error interno al validar la partida!" });
            }
        });
    }
