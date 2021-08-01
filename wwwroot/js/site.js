


function FillRankName()
{
    //alert("shahid");
    debugger;
    var RankCode = $('#RankDropdown :selected').text();
    var ExactCode = parseInt(RankCode, 10);
  
    debugger;
    $.ajax({

        url: "/Employee/GetRankName",
        type: "GET",
        dataType: 'json',
        data: { Id: ExactCode },

        success: function (html) {
            debugger;
            alert(html.rnK_CODE);
            $("#Name").val(html.rnk_desc);
            $('#RankDropdown :selected').val(response.rnK_CODE);
        },
        error: function (xhr, status, error) {
            alert("this code is in error")
        }
    });
}

function FillNationalityName() {
    debugger;
    var NationalityCode = $('#NationalityDropdown :selected').text();
   
    $.ajax({

        url: "/Employee/GetNationalityName",
        type: "GET",
        dataType: 'json',
        data: { Id: NationalityCode },

        success: function (response) {
         $("#NationalName").val(response);
        },
        error: function (xhr, status, error) {
            alert("this code is in error")
        }
    });
}




function FillSectionName() {
    debugger;
    var test = $('#Section').val()
        ;
    //var DeptCode = $('#DepartmentDropdown :selected').text();
    var data = {
           
        DEP_CODE: $("#DepartmentDropdown :selected").text(),
        SECId : $("#Section").val()
                                               
    };
    $.ajax({

        url: "/Employee/SectionName",
        type: "GET",
        dataType: 'json',
        data: data,

        success: function (response) {
            //$("#SectionName").val(response);

            if (response != null && response != "") {
                /* alert(response.responseText);*/
                $("#SectionName").val(response);
            } else {
              
                alert("Invalid Department");
            }
        },
        error: function (xhr, status, error) {
            alert("this code is in error")
        }
    });
}





function FillDepartmentName() {
    debugger;
    var DeptCode = $('#DepartmentDropdown :selected').text();
  
    $.ajax({
        url: "/Employee/GetDepartmentName",
        type: "GET",
        dataType: 'json',
        data: { Id: DeptCode },

        success: function (response) {
            //  alert(response);
            $("#DeptName").val(response);
        },
        error: function (xhr, status, error) {
            alert("this code is in error")
        }
    });
}
function FillPayScale() {
    debugger;
    var PayScaleCode = $('#PayScale :selected').text();

   
    $.ajax({

        url: "/Employee/PayScaleAmount",
        type: "GET",
        dataType: 'json',
        data: { Id: PayScaleCode },

        success: function (response) {
            //  alert(response);
            $("#Amount").val(response);
        },
        error: function (xhr, status, error) {
            alert("this code is in error")
        }
    });
}



$(document).ready(function () {

   $("#create").click(function (e) {
       //Var EmployeeMaster = {
       //    EMP_NO: $("#EmpCode").val(),
       //    NAME: $("#EmpName").val(),
       //    RNK_CODE: $("#RankDropdown").val(),
       //    SEX: $("#Gender").val(),
       //    MARITAL_ST: $("#Status").val(),
       //    DT_OF_BRTH: $("#datepicker").val(),
       //    STOP_ID: $("#SalaryStatus").val(),
       //    NAT_CODE: $("#NationalityDropdown").val(),
       //    DEP_CODE: $("#DepartmentDropdown").val(),
       //    SEC_CODE: $("#Section").val(),
       //    REASON: $("#Remarks").val()
       //};
   
       $.ajax({

            url: "/Employee/Create",
            type: "Post",
            dataType: 'json',
            //data: EmployeeMaster,
            data: {
                EMP_NO: $("#EmpCode").val(),
                NAME: $("#EmpName").val(),
                RNK_CODE: $("#RankDropdown").val(),
                SEX: $("#Gender").val(),
                MARITAL_ST: $("#Status").val(),
                DT_OF_BRTH: $("#datepicker").val(),
                STOP_ID: $("#SalaryStatus").val(),
                NAT_CODE: $("#NationalityDropdown").val(),
                DEP_CODE: $("#DepartmentDropdown").val(),
                SEC_CODE: $("#Section").val(),
                REASON: $("#Remarks").val()
            }
        });
    });
});
function EditButtonClick(id) {
    $.ajax({
        url: "/Employee/AddOrUpdate",
        type: "GET",
        dataType: "json",
        data: { Id: id },

        success: function (response) {
            $('#EmpCode').val(response.EmpCode);
            $('#EmpName').val(response.EmpName);
            $('#RankDropdown').val(response.RankDropdown);
            $('#Gender').val(response.Gender);
            $('#Status').val(response.Status);
            $('#datepicker').val(response.datepicker);
            $('#SalaryStatus').val(response.STOP_ID);
            $('#NationalityDropdown').val(response.NationalityDropdown);
            $('#DepartmentDropdown').val(response.DepartmentDropdown);
            $('#Section').val(response.Section);
            $('#Remarks').val(response.Remarks);
        }
    })
}
function DeleteButtonClick(id) {
    debugger
    alert("Are you Sure You Want to Delete!")
    $.ajax({

        url: "/Employee/Delete",
        type: "GET",
        dataType: "json",
        data: { Id: id },

        success: function (response) {
            alert("Record Deleted Successfully!")
        }
    })
}