# TicTacToe Game


- I wrote this game noodling around to just practice a bit, and have a game to play as a test for docker or k8 node check. It is not full featured and probably has issues somewhere. 


# Build docker image
``` docker build -t tictactoe-image -f Dockerfile .  ```

# Run the image and play the game. 
``` docker run -it --rm tictactoe-image ``` 