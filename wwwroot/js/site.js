// Function to show the thank you message
function showThankYouMessage() {
    // Show the hidden message div
    document.getElementById("thankYouMessage").style.display = "block";
}

// Check for query parameters in the URL to determine if the form was submitted
const urlParams = new URLSearchParams(window.location.search);
if (urlParams.has("submitted") && urlParams.get("submitted") === "true") {
    // If the "submitted" query parameter is present and set to "true", show the message
    showThankYouMessage();
}
