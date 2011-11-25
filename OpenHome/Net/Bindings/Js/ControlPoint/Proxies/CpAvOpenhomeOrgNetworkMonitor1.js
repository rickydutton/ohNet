 

/**
* Service Proxy for CpProxyAvOpenhomeOrgNetworkMonitor1
* @module ohNet
* @class NetworkMonitor
*/
	
var CpProxyAvOpenhomeOrgNetworkMonitor1 = function(udn){	

	this.url = window.location.protocol + "//" + window.location.host + "/" + udn + "/av.openhome.org-NetworkMonitor-1/control";  // upnp control url
	this.domain = "av-openhome-org";
	this.type = "NetworkMonitor";
	this.version = "1";
	this.serviceName = "av.openhome.org-NetworkMonitor-1";
	this.subscriptionId = "";  // Subscription identifier unique to each Subscription Manager 
	this.udn = udn;   // device name
	
	// Collection of service properties
	this.serviceProperties = {};
	this.serviceProperties["Name"] = new OhNet.ServiceProperty("Name","string");
	this.serviceProperties["Sender"] = new OhNet.ServiceProperty("Sender","int");
	this.serviceProperties["Receiver"] = new OhNet.ServiceProperty("Receiver","int");
	this.serviceProperties["Results"] = new OhNet.ServiceProperty("Results","int");
}



/**
* Subscribes the service to the subscription manager to listen for property change events
* @method Subscribe
* @param {Function} serviceAddedFunction The function that executes once the subscription is successful
*/
CpProxyAvOpenhomeOrgNetworkMonitor1.prototype.subscribe = function (serviceAddedFunction) {
    OhNet.SubscriptionManager.addService(this,serviceAddedFunction);
}


/**
* Unsubscribes the service from the subscription manager to stop listening for property change events
* @method Unsubscribe
*/
CpProxyAvOpenhomeOrgNetworkMonitor1.prototype.unsubscribe = function () {
    OhNet.SubscriptionManager.removeService(this.subscriptionId);
}


	

/**
* Adds a listener to handle "Name" property change events
* @method Name_Changed
* @param {Function} stateChangedFunction The handler for state changes
*/
CpProxyAvOpenhomeOrgNetworkMonitor1.prototype.Name_Changed = function (stateChangedFunction) {
    this.serviceProperties.Name.addListener(function (state) 
	{ 
		stateChangedFunction(OhNet.SoapRequest.readStringParameter(state)); 
	});
}
	

/**
* Adds a listener to handle "Sender" property change events
* @method Sender_Changed
* @param {Function} stateChangedFunction The handler for state changes
*/
CpProxyAvOpenhomeOrgNetworkMonitor1.prototype.Sender_Changed = function (stateChangedFunction) {
    this.serviceProperties.Sender.addListener(function (state) 
	{ 
		stateChangedFunction(OhNet.SoapRequest.readIntParameter(state)); 
	});
}
	

/**
* Adds a listener to handle "Receiver" property change events
* @method Receiver_Changed
* @param {Function} stateChangedFunction The handler for state changes
*/
CpProxyAvOpenhomeOrgNetworkMonitor1.prototype.Receiver_Changed = function (stateChangedFunction) {
    this.serviceProperties.Receiver.addListener(function (state) 
	{ 
		stateChangedFunction(OhNet.SoapRequest.readIntParameter(state)); 
	});
}
	

/**
* Adds a listener to handle "Results" property change events
* @method Results_Changed
* @param {Function} stateChangedFunction The handler for state changes
*/
CpProxyAvOpenhomeOrgNetworkMonitor1.prototype.Results_Changed = function (stateChangedFunction) {
    this.serviceProperties.Results.addListener(function (state) 
	{ 
		stateChangedFunction(OhNet.SoapRequest.readIntParameter(state)); 
	});
}


/**
* A service action to Name
* @method Name
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
CpProxyAvOpenhomeOrgNetworkMonitor1.prototype.Name = function(successFunction, errorFunction){	
	var request = new OhNet.SoapRequest("Name", this.url, this.domain, this.type, this.version);		
    request.send(function(result){
		result["Name"] = OhNet.SoapRequest.readStringParameter(result["Name"]);	
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}


/**
* A service action to Ports
* @method Ports
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
CpProxyAvOpenhomeOrgNetworkMonitor1.prototype.Ports = function(successFunction, errorFunction){	
	var request = new OhNet.SoapRequest("Ports", this.url, this.domain, this.type, this.version);		
    request.send(function(result){
		result["Sender"] = OhNet.SoapRequest.readIntParameter(result["Sender"]);	
		result["Receiver"] = OhNet.SoapRequest.readIntParameter(result["Receiver"]);	
		result["Results"] = OhNet.SoapRequest.readIntParameter(result["Results"]);	
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}



