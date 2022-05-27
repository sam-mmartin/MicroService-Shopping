$(function () {
   var id;
   $(".linkDelete").click(function () {
      id = $(this).attr('data-id');
      var action = "/Product/Delete/" + id;
      $("#formDelete").attr("action", action);
   })
})