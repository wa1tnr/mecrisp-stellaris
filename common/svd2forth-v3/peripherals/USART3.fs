\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40004800 constant USART3 ( Universal synchronous asynchronous receiver  transmitter ) 
USART3 0x0 + constant USART3-SR ( Status register ) 
USART3 0x4 + constant USART3-DR ( Data register ) 
USART3 0x8 + constant USART3-BRR ( Baud rate register ) 
USART3 0xC + constant USART3-CR1 ( Control register 1 ) 
USART3 0x10 + constant USART3-CR2 ( Control register 2 ) 
USART3 0x14 + constant USART3-CR3 ( Control register 3 ) 
USART3 0x18 + constant USART3-GTPR ( Guard time and prescaler  register ) 
