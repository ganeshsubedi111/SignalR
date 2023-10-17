"use strict"; 
var connection = new signalR.HubConnectionBuilder().withUrl("/notificationHub").build();
connection.start();
connection.on("ReceiveMsg", function (message) {
    var li = document.createElement("li");
    li.textContent = message;
    document.getElementById("msglist").appendChild(li);

});