// 
function updateStory() {
    var finalAnswer = storyOutput;
    document.getElementById('story').innerHTML = finalAnswer;
};

// 
var storyOutput = "Hey! This is an interactive story. Do you want to take part?";
updateStory();

//
document.getElementById('javascriptButton').onclick = function interpretAnswer() {
    var inputResults = document.getElementById('answerField').value;
    answer = inputResults.toUpperCase();
    checkAnswer();
};

//
function checkAnswer() {
    if (answer === "YES") {
        storyOutput = "Excellent!";
    }
    else if (answer === "CAN I THINK ABOUT IT?") {
        storyOutput = "Sure! Type something else in whenever you're ready.";
    }
    else if (answer === 'NO') {
        storyOutput = "Aw! Okay. See you later.";
    }
    else {
        // With no results, or bad results, repeat the question with more detail:
        storyOutput = "Hey! This is an interactive story. Do you want to take part? YES or NO";
    };
    updateStory();

}
//comment js


//my globe 

