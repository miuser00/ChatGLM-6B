cd..
set GIT=git\\cmd\\git.exe
set PYTHON=Python39\\python.exe

%PYTHON% chatglm_UI.py --precision int8 --model-path "model\models--THUDM--chatglm-6b-int8"

pause
exit /b