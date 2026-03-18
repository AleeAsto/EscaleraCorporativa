#Requires AutoHotkey v2.0

;GOLPE
1:: {
	Send("{b}")
	Send("{w down}")
	Sleep(200)
	Send("{w up}{s down}")
	Sleep(200)
	Send("{s up}")
}
2:: {
	Send("{v}")
	Send("{w down}")
	Sleep(200)
	Send("{w up}{s down}")
	Sleep(200)
	Send("{s up}")
}

;SALIR DEL SCRIPT
Esc:: {
    Send("{w up}{a up}{s up}{d up}{q up}{e up}")
    Send("{Up up}{Down up}{Left up}{Right up}")
    Send("{Shift up}{Ctrl up}{Alt up}")
}

9::Suspend(-1)
0::ExitApp()