ko.bindingHandlers.bootstrapRadioButtonGroup =
{
	init: function (element)
	{
		$(element).addClass("btn-group");
	},

	update: function (element, valueAccessor, allBindings)
	{
		var buttons = ko.unwrap(valueAccessor());
		var $element = $(element);
		if ($element.attr("bootstrapRadioButtonValueUpdate"))
		{
			$("button", element).each(function (index)
			{
				$(this).toggleClass("btn-primary", allBindings.get('value')() == (buttons[index].hasOwnProperty("value") ? buttons[index].value : buttons[index]));
			});

			$element.removeAttr("bootstrapRadioButtonValueUpdate");
			return;
		}

		$element.empty();
		for (var i = 0; i < buttons.length; i++)
			$("<button>").appendTo(element);

		$("button", element).each(function (index)
		{
			var $this = $(this);
			$this.text(buttons[index].hasOwnProperty("text") ? buttons[index].text : buttons[index].hasOwnProperty("label") ? buttons[index].label : buttons[index])
				.addClass("customButtons btn btn-primary")
				.click(function ()
				{
					$element.attr("bootstrapRadioButtonValueUpdate", true);
					allBindings.get('value')(buttons[index].hasOwnProperty("value") ? buttons[index].value : buttons[index]);
					return false;
				})
				
				.toggleClass("btn-primary", allBindings.get('value')() == (buttons[index].hasOwnProperty("value") ? buttons[index].value : buttons[index]));

			var attributes = allBindings.get('attributes');
			if (!attributes)
				return;

			for (var attribute in attributes)
			    $this.attr(attribute, attributes[attribute]);

			
		});
	}
};