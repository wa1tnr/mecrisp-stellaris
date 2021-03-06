\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40011800 constant GPIOE ( General purpose I/O ) 
GPIOE 0x0 + constant GPIOE-CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOE 0x4 + constant GPIOE-CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOE 0x8 + constant GPIOE-IDR ( Port input data register  GPIOn_IDR ) 
GPIOE 0xC + constant GPIOE-ODR ( Port output data register  GPIOn_ODR ) 
GPIOE 0x10 + constant GPIOE-BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOE 0x14 + constant GPIOE-BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOE 0x18 + constant GPIOE-LCKR ( Port configuration lock  register ) 
