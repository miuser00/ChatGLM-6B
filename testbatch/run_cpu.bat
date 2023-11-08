cd..
set GIT=git\\cmd\\git.exe
set PYTHON=Python39\\python.exe

%PYTHON% chatglm_UI.py --precision cpu --model-path "model\models--THUDM--chatglm-6b" 

pause
exit /b