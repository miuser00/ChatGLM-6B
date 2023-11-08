cd..
set GIT=git\\cmd\\git.exe
set PYTHON=Python39\\python.exe

%PYTHON% chatglm_UI.py --precision int4 --model-path "model\models--THUDM--chatglm-6b-int4" 

pause
exit /b