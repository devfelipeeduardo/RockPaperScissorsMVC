let playerChoiceImg = document.getElementById("player-choice-img");
let playerChoice = playerChoiceImg.getAttribute("data-resposta");

if (playerChoice == "Pedra") {
    playerChoiceImg.src = "/imgs/rock.png";
}
else if (playerChoice == "Papel") {
    playerChoiceImg.src = "/imgs/paper.png";
}
else if (playerChoice == "Tesoura") {
    playerChoiceImg.src = "/imgs/scissor.png";
}


let computerChoiceImg = document.getElementById("computer-choice-img");
let computerChoice = computerChoiceImg.getAttribute("data-resposta");

if (computerChoice == "Pedra") {
    computerChoiceImg.src = "/imgs/rock.png";
}
else if (computerChoice == "Papel") {
    computerChoiceImg.src = "/imgs/paper.png";
}
else if (computerChoice == "Tesoura") {
    computerChoiceImg.src = "/imgs/scissor.png";
}