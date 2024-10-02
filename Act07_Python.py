# -*- coding: utf-8 -*-
"""
Created on Tue Oct  1 23:15:55 2024

@author: HP
"""

import serial
import tkinder as tk

puerto_serial = serial.Seral("com7", 9600)

def a ():
    puerto_serial.write(b´b´)
def b ():
    puerto_serial.write(b´a´)
    
    
    ventana=tk.Tk()
    ventana.tittle("Led")
    
    encender = tk.Button(ventana, text= "Encendido", command=a)
    encender.pack(pady=10)
    
    apagar = tk.Button(ventana, text= "Apagado", command=b)
    apagar.pack(pady=10)
    
    
    ventana.mainloop()
    
    puerto_serial.close()
    
    