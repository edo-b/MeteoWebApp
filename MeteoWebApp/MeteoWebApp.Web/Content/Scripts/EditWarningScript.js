$(document).ready(function () {
    $('[data-toggle="tooltip"]').tooltip();
    $('.delete-button').click(function () {
        var clickedDeleteButton = $(this);
        $('#delete-id-field').attr('value', clickedDeleteButton.attr('data'));
    });
})