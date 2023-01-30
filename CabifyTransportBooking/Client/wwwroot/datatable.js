using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CabifyTransportBooking.Client.wwwroot
{
    public class datatable
    {
        function AddDataTable(table) {
        $(document).ready(function () {
            $(table).DataTable();
        })
    }
    function DataTablesDispose(table) {
        $(document).ready(function () {
            $(table).DataTable().destroy();
            var element = document.querySelector(table + '_wrapper');
            element.parentNode.removeChild(element);
        })
    }
    }
}
