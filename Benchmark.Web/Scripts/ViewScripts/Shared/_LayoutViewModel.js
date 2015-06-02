var LayoutViewModel = function () {

    var self = this;
    self.navbarRight = ko.observableArray(mappedNavbarRight);
    self.navbarLeft = ko.observableArray(mappedNavbarLeft);
    self.navbar = ko.computed(function() {
        var data = ko.observableArray([]);
        self.navbarLeft().forEach(function(item) {
            data.push(item);
        });
        self.navbarRight().forEach(function (item) {
            data.push(item);
        });
        return data();
    });
    self.isLoggedIn = ko.observable(model.Menu.UserLoggedIn);

    self.goHome = function() {
        changeLocation("Home/OfficeAdmin", true);
    }
};

var NavigationItemViewModel = function (navigationItem) {
    var self = this;
    self.HRef = ko.observable(getLocation(navigationItem.HRef,true));
    self.Id = ko.observable(navigationItem.Id);
    self.Text = ko.observable(navigationItem.TranslationKey ? translation[navigationItem.Text] : navigationItem.Text);
    self.UseRootUrl = ko.observable(navigationItem.UseRootUrl);
    //self.selectedItemId = selectedItemId;

    self.isSelected = ko.computed(function () {
        return self.selectedItemId && (self.Id() === self.selectedItemId());
    }, self);

    self.gotoLocation = function () {
        changeLocation(self.HRef(), self.UseRootUrl());
    }
}

var mappedNavbarRight = ko.utils.arrayMap(model.Menu.NavbarRight, function (item) {
    return new NavigationItemViewModel(item);
});

var mappedNavbarLeft = ko.utils.arrayMap(model.Menu.NavbarLeft, function (item) {
    return new NavigationItemViewModel(item);
});
