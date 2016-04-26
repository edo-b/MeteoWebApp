function validateForm(formType) {
    if (formType == 'create') {
        var rainChance = $('#create-rain-chance-field').val();
        var windSpeed = $('#create-wind-speed-field').val();

        var errorString = "";
        var didErrorOccur = false;

        $('#create-validation-failed-warning').html("");

        if (rainChance < 0 || rainChance > 100) {
            errorString = "Vjerojatnost kiše mora biti od 0 do 100";
            didErrorOccur = true;
        }
        if (windSpeed < 0 || windSpeed > 100) {
            if (errorString == "") {
                errorString = "Brzina vjetra mora biti veća od 0";
                didErrorOccur = true;
            }
            else {
                errorString += ", brzina vjetra mora biti veća od 0";
                didErrorOccur = true;
            }
        }
        if (didErrorOccur == true) {
            var warningHtml = "<div class=\"alert alert-danger\"><a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a><strong>Greška!</strong> " + errorString + ".</div>";
            $('#create-validation-failed-warning').html(warningHtml);
            return false;
        }

        return true;
    }
    else if (formType == 'edit') {
        var rainChance = $('#edit-rain-chance-field').val();
        var windSpeed = $('#edit-wind-speed-field').val();

        var errorString = "";
        var didErrorOccur = false;

        $('#edit-validation-failed-warning').html("");

        if (rainChance < 0 || rainChance > 100) {
            errorString = "Vjerojatnost kiše mora biti od 0 do 100";
            didErrorOccur = true;
        }
        if (windSpeed < 0 || windSpeed > 100) {
            if (errorString == "") {
                errorString = "Brzina vjetra mora biti veća od 0";
                didErrorOccur = true;
            }
            else {
                errorString += ", brzina vjetra mora biti veća od 0";
                didErrorOccur = true;
            }
        }
        if (didErrorOccur == true) {
            var warningHtml = "<div class=\"alert alert-danger\"><a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a><strong>Greška!</strong> " + errorString + ".</div>";
            $('#edit-validation-failed-warning').html(warningHtml);
            return false;
        }

        return true;
    }
}