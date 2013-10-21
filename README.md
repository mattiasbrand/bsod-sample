BSOD sample
===========

Reproduce:
1. Install virtualbox https://www.virtualbox.org/wiki/Downloads (also managed to reproduce with a semi-old version of Sonicwall VPN Client)
2. Restart computer
3. Start 2 instances of LoupeBSOD.exe (a WPF-program with a loupe agent).
4. Put computer to sleep
5. Wake computer
6. Close 1 instance of LoupeBSOD.exe
7. Wait 0-10 seconds
8. BSOD => ndis.sys

