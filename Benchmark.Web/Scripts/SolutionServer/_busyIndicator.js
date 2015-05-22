/*busyViewModel functions:

	- show (message, messageContext)
		- shows the busy indicator
		- message (optional) and messageContext (optional): will be forwarded to setMessage

	- hide ()
		- hides the busy indicator

	- setMessage (message, messageContext)
		- shows a message on the busy indicator
		- message (optional): the message to be displayed. empty message the same as hideMessage
		- messageContext (optional): can be 'default', 'success', 'info', 'warning' or 'danger'. empty messageContext the same as 'default'

	- hideMessage ()
		- hides the message, but not the busy indicator

	- setProgress (percentage, barContext, message)
		- shows a progress bar on the busy indicator
		- percentage (optional): percentage of progress bar. empty percentage the same as hideProgress
		- barContext (optional): can be 'default', 'success', 'info', 'warning' or 'danger'. empty messageContext the same as 'default'
		- message (optional): message to be displayed on the progress bar if no main message area is visible,
		else it will be displayed next to main message in a badge. empty message is the same as percentage+"%"

	- hideProgress ()
		- hides the progress bar, but not the busy indicator

busyViewModel.IsBusy function has been deprecated. Use busyViewModel.show() or busyViewModel.hide() instead.
*/

$('#SpinnerModal').modal({ backdrop: 'static', show: true });

function BusyViewModel(target)
{
	var self = this;

	var spinnerOptions =
		{
			lines: 0, // The number of lines to draw
			length: 3, // The length of each line
			width: 10, // The line thickness
			radius: 15, // The radius of the inner circle
			corners: 1, // Corner roundness (0..1)
			rotate: 0, // The rotation offset
			direction: 1, // 1: clockwise, -1: counterclockwise
			color: '#fff',//'#5cb85c', // #rgb or #rrggbb
			speed: 0.5, // Rounds per second
			trail: 24, // Afterglow percentage
			shadow: false, // Whether to render a shadow
            hwaccel: false, // Whether to use hardware acceleration
			zIndex: 2e9, // The z-index (defaults to 2000000000)
			top: '90%', // Top position relative to parent in px
			left: '50%' // Left position relative to parent in px
		};

	var companyLogo =
	{
	    image: '<img src="~/Content/Images/Login Logo.png"  />'
	}

	var $spinner = $('#Spinner');
	var spinner = new Spinner(spinnerOptions);
	spinner.spin(target ? target : $spinner[0]);

	var $spinnerModal = $('#SpinnerModal');
	var $spinnerModalMessage = $('#SpinnerModalMessage');
	var $spinnerModalProgressMessage = $('#SpinnerModalProgressMessage');
	var $spinnerModalProgressBar = $('#SpinnerModalProgressBar');

	self.IsBusy = function (isBusy) //should be removed once all calls to IsBusy are gone
	{
		console.log("WARNING: busyViewModel.IsBusy function has been deprecated. Use busyViewModel.show() or busyViewModel.hide() instead.");
		self.isBusy(isBusy);
	};

	self.isBusy = function (isBusy) //should be removed once all calls to isBusy are gone
	{
		console.log("WARNING: busyViewModel.isBusy function has been deprecated. Use busyViewModel.show() or busyViewModel.hide() instead.");
		if (!isBusy)
		{
			self.hide();
			return;
		}
		self.show();
	};

	self.show = function (message, messageContext) //message, percentage and progressMessage are all optional
	{
	    $spinnerModal.modal('show'); //if $('#SpinnerModal').modal is undefined, check for duplicate jquery links
	    $('#navbarDiv').addClass("blur");
	    $('#body').addClass("blur");
		self.setMessage(message, messageContext);
	};

	self.hide = function ()
	{
		$spinnerModal.modal('hide'); //if $('#SpinnerModal').modal is undefined, check for duplicate jquery links
		$spinner.removeClass("alert-default");
		$('#navbarDiv').removeClass("blur");
		$('#body').removeClass("blur");
		self.hideProgress();
	};

	self.setMessage = function (message, messageContext)
	{
		if (!message)
		{
			self.hideMessage();
			return;
		}

		showMessage(message, messageContext);
	}

	var showMessage = function (message, messageContext)
	{
		$spinner.addClass("alert-default");
		$spinnerModalMessage.children().first().text(message);
		$spinnerModalMessage
			.removeClass("alert-default alert-success alert-info alert-warning alert-danger")
			.addClass("alert-" + (messageContext ? messageContext.toLowerCase() : "default"))
			.show();
	}

	self.hideMessage = function ()
	{
		$spinnerModalMessage.hide();
		if (!$spinnerModalProgressBar.is(":visible"))
			$spinner.removeClass("alert-default");
	}

	self.setProgress = function (percentage, barContext, message)
	{
		if (!percentage && percentage !== 0)
		{
			self.hideProgress();
			return;
		}

		showProgress(percentage, barContext, message);
	}

	var showProgress = function (percentage, barContext, message)
	{
		$spinner.addClass("alert-default");
		if (!message)
			message = percentage + "%";
		setProgressMessage(message);
		$spinnerModalProgressBar.children().first()
			.removeClass("progress-bar-default progress-bar-success progress-bar-info progress-bar-warning progress-bar-danger")
			.addClass("progress-bar-" + (barContext ? barContext.toLowerCase() : "default"))
			.css({ width: percentage + "%" })
			.attr({ 'aria-valuenow': percentage, width: percentage + "%" })
			.html(!$spinnerModalMessage.is(":visible") ? message : "<span class='sr-only'>" + percentage + "%</span>");
		$spinnerModalProgressBar.show();
	}

	self.hideProgress = function ()
	{
		$spinnerModalProgressBar.hide();
		$spinnerModalProgressMessage.hide();
		if (!$spinnerModalMessage.is(":visible"))
			$spinner.removeClass("alert-default");
	}

	var setProgressMessage = function (message)
	{
		if (!$spinnerModalMessage.is(":visible"))
		{
			$spinnerModalProgressMessage.hide();
			return;
		}

		$spinnerModalProgressMessage
			.text(message)
			.show();
	}
}

var busyViewModel = new BusyViewModel();

