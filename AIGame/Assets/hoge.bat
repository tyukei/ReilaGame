@echo off

rem文字コードをUTF-8に指定（パスに日本語がなければ不要）
chcp 65001
rem 仮想環境をActivateするための特殊なバッチファイルを起動
call C:\Users\nakat\Anaconda3\Scripts\activate.bat
echo call conda
rem 仮想環境をActivate
call activate ml-agents
echo call ml-agents

echo %~dp0
mlagents-learn ../../プログラミング/unity/AIGame/Assets/Config/DogBrain.yaml --run-id=DogBrain-ppo-1--env=test --force
echo finish
pause

