$(function () {
    // Declare a proxy to reference the hub. 
    var talk = $.connection.messageHub;
    // Create a function that the hub can call to broadcast messages.
    talk.client.broadcast = function (name, message) {
        // Html encode display name and message. 
        var encodedName = $('<div />').text(name).html();
        var encodedMsg = $('<div />').text(message).html();
        // Add the message to the page.
        addToDiscussion('<strong>' + encodedName + '</strong>:&nbsp;&nbsp;' + encodedMsg);
        //$discussion.prepend('<li><strong>' + encodedName
        //    + '</strong>:&nbsp;&nbsp;' + encodedMsg + '</li>');
    };
    // Create a function that the hub can call to raise swear alerts.
    talk.client.swearAlert = function (name) {
        // Html encode display name and message. 
        var encodedName = $('<div />').text(name).html();
        var encodedMsg = $('<div />').text(message).html();
        // Add the message to the page. 
        addToDiscussion('<strong>' + encodedName + ' has used an expletive. What a cunt.</strong>', 'highlight');
        //$discussion.prepend('<li class="highlight"><strong>' + encodedName + ' has used an expletive. What a cunt.</strong></li>');
    };
    // Set initial focus to message input box.  
    $('#message').focus();
    // Start the connection.
    $.connection.hub.start().done(function () {
        $('#sendmessage').click(function () {
            // Call the Send method on the hub. 
            talk.server.send($('#displayname').val(), $('#message').val());
            // Clear text box and reset focus for next comment. 
            $('#message').val('').focus();
        });
    });
});
addToDiscussion = function (html, elementClass) {
    // The discussion.
    var $discussion = $('#discussion');
    $discussion.prepend('<li class"' + elementClass + '">' + html + '</li>');
    var discussionLength = $discussion.find('li').length;
    if (discussionLength > 10) {
        $($discussion.find('li')[discussionLength - 1]).remove();
    }
}