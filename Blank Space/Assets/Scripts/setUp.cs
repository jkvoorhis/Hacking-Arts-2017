u s i n g   S y s t e m . C o l l e c t i o n s ;  
 u s i n g   S y s t e m . C o l l e c t i o n s . G e n e r i c ;  
 u s i n g   U n i t y E n g i n e ;  
  
 p u b l i c   c l a s s   s e t U p   :   M o n o B e h a v i o u r   {  
 	 p u b l i c   G a m e O b j e c t   c u b e P r e f a b ;  
  
 	 v o i d   S t a r t   ( )   {  
 	 	 V e c t o r 3   c a m P o s   =   C a m e r a . m a i n . t r a n s f o r m . p o s i t i o n ;  
 	 	 f o r   ( i n t   i   =   0 ;   i   <   1 5 ;   i + + )   {  
 	 	 	 I n s t a n t i a t e   (  
 	 	 	 	 c u b e P r e f a b ,    
 	 	 	 	 n e w   V e c t o r 3 (  
 	 	 	 	 	 c a m P o s . x   +   R a n d o m . R a n g e (   - 2 5 . 0 f ,   2 5 . 0 f   ) ,    
 	 	 	 	 	 c a m P o s . y   +   R a n d o m . R a n g e (   - 2 5 . 0 f ,   2 5 . 0 f   ) ,    
 	 	 	 	 	 c a m P o s . z   +   R a n d o m . R a n g e (   - 2 5 . 0 f ,   2 5 . 0 f   )  
 	 	 	 	 ) ,  
 	 	 	 	 Q u a t e r n i o n . i d e n t i t y  
 	 	 	 ) ;  
 	 	 }  
 	 }  
  
 	 v o i d   U p d a t e   ( )   {  
 	 	  
 	 }  
 }  
  
 