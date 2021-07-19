

function FillRankName()
{
    alert("shahid");
    debugger;
    var abc = $("#RankDropdown").val();
    var RankCode = $('#RankDropdown :selected').text();
  
    debugger;
    $.ajax({

        url: "/Employee/GetRankName",
        type: "GET",
        dataType: 'json',
        data: { Id: RankCode },

        success: function (response) {
          //  alert(response);
            $("#Name").val(response);
        },
        error: function (xhr, status, error) {
            alert("this code is in error")
        }
    });
}