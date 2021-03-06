﻿
var makesModelsJsonGlobal = {};
var modelDetails = {};


var states = [
    {
        "name": "Please Select s State",
        "abbreviation": "-1"
    },
    {
        "name": "Alabama",
        "abbreviation": "AL"
    },
    {
        "name": "Alaska",
        "abbreviation": "AK"
    },
    {
        "name": "American Samoa",
        "abbreviation": "AS"
    },
    {
        "name": "Arizona",
        "abbreviation": "AZ"
    },
    {
        "name": "Arkansas",
        "abbreviation": "AR"
    },
    {
        "name": "California",
        "abbreviation": "CA"
    },
    {
        "name": "Colorado",
        "abbreviation": "CO"
    },
    {
        "name": "Connecticut",
        "abbreviation": "CT"
    },
    {
        "name": "Delaware",
        "abbreviation": "DE"
    },
    {
        "name": "District Of Columbia",
        "abbreviation": "DC"
    },
    {
        "name": "Federated States Of Micronesia",
        "abbreviation": "FM"
    },
    {
        "name": "Florida",
        "abbreviation": "FL"
    },
    {
        "name": "Georgia",
        "abbreviation": "GA"
    },
    {
        "name": "Guam",
        "abbreviation": "GU"
    },
    {
        "name": "Hawaii",
        "abbreviation": "HI"
    },
    {
        "name": "Idaho",
        "abbreviation": "ID"
    },
    {
        "name": "Illinois",
        "abbreviation": "IL"
    },
    {
        "name": "Indiana",
        "abbreviation": "IN"
    },
    {
        "name": "Iowa",
        "abbreviation": "IA"
    },
    {
        "name": "Kansas",
        "abbreviation": "KS"
    },
    {
        "name": "Kentucky",
        "abbreviation": "KY"
    },
    {
        "name": "Louisiana",
        "abbreviation": "LA"
    },
    {
        "name": "Maine",
        "abbreviation": "ME"
    },
    {
        "name": "Marshall Islands",
        "abbreviation": "MH"
    },
    {
        "name": "Maryland",
        "abbreviation": "MD"
    },
    {
        "name": "Massachusetts",
        "abbreviation": "MA"
    },
    {
        "name": "Michigan",
        "abbreviation": "MI"
    },
    {
        "name": "Minnesota",
        "abbreviation": "MN"
    },
    {
        "name": "Mississippi",
        "abbreviation": "MS"
    },
    {
        "name": "Missouri",
        "abbreviation": "MO"
    },
    {
        "name": "Montana",
        "abbreviation": "MT"
    },
    {
        "name": "Nebraska",
        "abbreviation": "NE"
    },
    {
        "name": "Nevada",
        "abbreviation": "NV"
    },
    {
        "name": "New Hampshire",
        "abbreviation": "NH"
    },
    {
        "name": "New Jersey",
        "abbreviation": "NJ"
    },
    {
        "name": "New Mexico",
        "abbreviation": "NM"
    },
    {
        "name": "New York",
        "abbreviation": "NY"
    },
    {
        "name": "North Carolina",
        "abbreviation": "NC"
    },
    {
        "name": "North Dakota",
        "abbreviation": "ND"
    },
    {
        "name": "Northern Mariana Islands",
        "abbreviation": "MP"
    },
    {
        "name": "Ohio",
        "abbreviation": "OH"
    },
    {
        "name": "Oklahoma",
        "abbreviation": "OK"
    },
    {
        "name": "Oregon",
        "abbreviation": "OR"
    },
    {
        "name": "Palau",
        "abbreviation": "PW"
    },
    {
        "name": "Pennsylvania",
        "abbreviation": "PA"
    },
    {
        "name": "Puerto Rico",
        "abbreviation": "PR"
    },
    {
        "name": "Rhode Island",
        "abbreviation": "RI"
    },
    {
        "name": "South Carolina",
        "abbreviation": "SC"
    },
    {
        "name": "South Dakota",
        "abbreviation": "SD"
    },
    {
        "name": "Tennessee",
        "abbreviation": "TN"
    },
    {
        "name": "Texas",
        "abbreviation": "TX"
    },
    {
        "name": "Utah",
        "abbreviation": "UT"
    },
    {
        "name": "Vermont",
        "abbreviation": "VT"
    },
    {
        "name": "Virgin Islands",
        "abbreviation": "VI"
    },
    {
        "name": "Virginia",
        "abbreviation": "VA"
    },
    {
        "name": "Washington",
        "abbreviation": "WA"
    },
    {
        "name": "West Virginia",
        "abbreviation": "WV"
    },
    {
        "name": "Wisconsin",
        "abbreviation": "WI"
    },
    {
        "name": "Wyoming",
        "abbreviation": "WY"
    }
];
var educationlevels = [
    {
        "text": "Please Select education level",
        "label": "please-select-education",
        "id": "-1"
    },
    {
        "text": "No formal education",
        "label": "no-formal-education",
        "id": "1"
    },
    {
        "text": "Less than high school",
        "label": "less-than-high-school",
        "id": "2"
    },
    {
        "text": "High School",
        "label": "high-school",
        "id": "3"
    },
    {
        "text": "Some college",
        "label": "some-college",
        "id": "4"
    },
    {
        "text": "Bachelor's degree",
        "label": "bachelors-degree",
        "id": "5"
    },
    {
        "text": "Graduate or professional degree",
        "label": "graduate-or-professional-degree",
        "id": "6"
    }
];

var vehicleYears = document.getElementById('Vehicle.Year');
if (vehicleYears != null)
{
    vehicleYears.add(new Option("Select a State", -1));
    for (i = new Date().getFullYear(); i > 1900; i--) {
        vehicleYears.add(new Option(i));
    }
}

var quotestate = document.getElementById('Quote.State');
var driverstate = document.getElementById('Driver.State');

if (quotestate != null)
{
    for (var i = 0; i < states.length; i++) {
        states[i] = "<option value='" + states[i].abbreviation + "'>" + states[i].name + "</option>";
    }
    quotestate.innerHTML = states;
}


if (driverstate != null) {
    for (var i = 0; i < states.length; i++) {
        states[i] = "<option value='" + states[i].abbreviation + "'>" + states[i].name + "</option>";
    }
    driverstate.innerHTML = states;
}



var edlevdd = document.getElementById('Driver.EducationLevel');
if (edlevdd != null)
{
    for (var i = 0; i < educationlevels.length; i++) {
        educationlevels[i] = "<option value='" + educationlevels[i].label + "'>" + educationlevels[i].text + "</option>";
    }
    edlevdd.innerHTML = educationlevels;
}


var getVehicleMakes = (function () {
    var year = document.getElementById("Vehicle.Year").value;
    var _edmondurl = document.getElementById('edmondApiUrl').value;
    var _edAPIKey = document.getElementById('edmundApiKey').value;
    var urlSuffix = "vehicle/v2/makes?state=used&year=" + year + "&view=basic&fmt=json&api_key=" + _edAPIKey;
    var reqURL = _edmondurl + urlSuffix;

    var req = new XMLHttpRequest();
    req.open('GET', reqURL, true);
    req.send();

    req.onreadystatechange = processRequest;

    function processRequest(e) {
        if (req.readyState == 4 && req.status == 200) {
            var makesModelsJson = JSON.parse(req.responseText);
            var makedd = document.getElementById('Vehicle.Make');
            makedd.options.length = 0;
            makedd.add(new Option("Please Select a Make", "-1"));
            for (i = 0; i < makesModelsJson.makes.length; i++) {
                
                makedd.add(new Option(makesModelsJson.makes[i].name, makesModelsJson.makes[i].name));
            }
            makesModelsJsonGlobal = makesModelsJson;
          
        }
    };


});

var getVehicleModels = (function () {
    var make = document.getElementById('Vehicle.Make').value;
    var modeldd = document.getElementById('Vehicle.Model');
    modeldd.options.length = 0;
    modeldd.add(new Option("Please Select a Model", "-1"));
    for (i = 0; i < makesModelsJsonGlobal.makes.length; i++)
    {
        if(makesModelsJsonGlobal.makes[i].name == make)
        {
            var models = makesModelsJsonGlobal.makes[i].models; 
            for (z = 0; z < models.length; z++)
            {
                modeldd.add(new Option(models[z].name, models[z].name));
            }
        }
    }
});

var getVehicleModelDetails = (function () {

    var _edmondurl = document.getElementById('edmondApiUrl').value;
    var _edAPIKey = document.getElementById('edmundApiKey').value;
    var make = document.getElementById('Vehicle.Make');
    var makeText = make.options[make.selectedIndex].text;
    var model = document.getElementById('Vehicle.Model');
    var modelText = model.options[model.selectedIndex].text;
    var year = document.getElementById('Vehicle.Year');
    var yearText = year.options[year.selectedIndex].text;

    var urlSuffix = "vehicle/v2/" + makeText + "/" + modelText + "/" + yearText + "/styles?state=used&view=full&fmt=json&api_key=" + _edAPIKey;

    var reqURL = _edmondurl + urlSuffix;

    var req = new XMLHttpRequest();
    req.open('GET', reqURL, true);
    req.send();

    req.onreadystatechange = processRequest;

    function processRequest(e) {
        if (req.readyState == 4 && req.status == 200) {
            var details = JSON.parse(req.responseText);
            modelDetails = details; 
            var detaildd = document.getElementById('Vehicle.Detail');
            detaildd.options.length = 0;
            detaildd.add(new Option("New Select a detail option", "-1"));
            for (i = 0; i < details.styles.length; i++) {
                detaildd.add(new Option("Style: " + details.styles[i].name + "  VIN: " + details.styles[i].squishVins[0], details.styles[i].name));
            }
        }
    };
});

var getWheels = (function () {

    var detail = document.getElementById('Vehicle.Detail');
    var cost = document.getElementById('Vehicle_CostNew');
    var wheels = document.getElementById('Vehicle_DriveTrainWheels');
    var detailSelection = detail.options[detail.selectedIndex];

    for(i = 0; i < modelDetails.styles.length; i++)
    {
        if (modelDetails.styles[i].name == detailSelection.value)
        {
            cost.value = modelDetails.styles[i].price.baseMSRP;
            wheels.value = modelDetails.styles[i].drivenWheels;
        }
    }
    //var cost = document.getElementById("Cost").Value = 
});


var ShowModelPopUp = function (vehicleId) {

    $(".modal-body #vehicleId").val(vehicleId);

 
};

var SubmitCoverage = function () {

    var vehicleId = document.getElementById('vehicleId').value;
    var ComprehensiveCoverage = document.getElementById('Coverages_ComprehensiveLimits').value;
    var RentalCoverage = document.getElementById('Coverages_RentalLimits').value;
    var RoadSideCoverage = document.getElementById('Coverages_RoadsideCoverage').value;
    var GapCoverage = document.getElementById('Coverages_GapCoverageLimits').value;

   
    var data = { Id: '1' };

    var request = $.ajax({
        type: 'POST',
        url: '/Quote/UpdateVehicleCoverage',
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify({ vId: vehicleId, comp: ComprehensiveCoverage, rental: RentalCoverage, roadside: RoadSideCoverage, gap: GapCoverage }), //hard-coded value used for simplicity
        dataType: 'json'
    });

    request.done(function (msg) {
        var test = msg;
        
    });

    request.fail(function (jqXHR, textStatus, errorThrown) {
        var test = errorThrown;
    });
    
 
};

var SaveandExit = function () {
    //save quote info
};

var CreateCustomer = function () {


    var firstName = document.getElementById('Applicant_FirstName').value;
    var midI = document.getElementById('Applicant_MI').value;
    var lastName = document.getElementById('Applicant_LastName').value;
    var dtob = document.getElementById('Applicant_DOB').value;
    var phone = document.getElementById('Applicant_PhoneNumber').value;
    var cell = document.getElementById('Applicant_CellNumber').value;
    var emailAddress = document.getElementById('Applicant_EmailAddress').value;


    var request = $.ajax({
        type: 'POST',
        url: '/Quote/CreateCustomerAjax',
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify({ fn: firstName, mi:midI, ln: lastName, dob: dtob, pn: phone, cn: cell, email: emailAddress}), //hard-coded value used for simplicity
        dataType: 'json'
    });

    request.done(function (msg) {
        var test = msg;
        if(msg > 0)
        {
            window.location = "http://localhost:50317/Quote/CreatePolicy?qId=" + msg;
        }

    });

    request.fail(function (jqXHR, textStatus, errorThrown) {
        var test = errorThrown;
    });


};

var CreatePolicy = function () {

    var qId = document.getElementById('Quote_QuoteId').value;
    var add1 = document.getElementById('Quote_AddressLine1').value;
    var add2 = document.getElementById('Quote_AddressLine2').value;
    var cit = document.getElementById('Quote_City').value;
    var sta = document.getElementById('Quote.State').value;
    var zipc = document.getElementById('Quote_ZipCode').value;
    var years = document.getElementById('Quote_YearsAtAddress').value;    
    var numres = document.getElementById('Quote_NumResidentsinHouehold').value;
    var otveh = document.getElementById('Quote_OtherVehiclesInHouseHold').value;
    var mcins = document.getElementById('Quote_MonthsWithCurrentInsurance').value;
    var picomp = document.getElementById('Quote_PriorInsuranceCompany').value;
    var picompf = document.getElementById('Quote_PriorInsuranceCompanyFlag').value;



    var request = $.ajax({
        type: 'POST',
        url: '/Quote/CreatePolicyAjax',
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify({ qid: qId, a1: add1, a2: add2, ct: cit, st: sta, zip: zipc, yrs: years, numr: numres, otv: otveh, mci: mcins, pi: picomp, pif: picompf }), //hard-coded value used for simplicity
        dataType: 'json'
    });

    request.done(function (msg) {
        var test = msg;
        if (msg > 0) {
            window.location = "http://localhost:50317/Quote/CreateVehicles?qId=" + msg;
        }

    });

    request.fail(function (jqXHR, textStatus, errorThrown) {
        var test = errorThrown;
    });


};



