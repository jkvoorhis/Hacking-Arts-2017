u s i n g   S y s t e m . C o l l e c t i o n s ;  
 u s i n g   S y s t e m . C o l l e c t i o n s . G e n e r i c ;  
 u s i n g   U n i t y E n g i n e ;  
  
 p u b l i c   c l a s s   o b j e c t s   :   M o n o B e h a v i o u r   {  
 	 p u b l i c   C o l o r   c o l ;  
 	 p u b l i c   s t a t i c   f l o a t   S P E E D   =   . 1 f ;  
 	 p u b l i c   f l o a t   x s p e e d ;  
 	 p u b l i c   f l o a t   y s p e e d ;  
 	 p u b l i c   f l o a t   z s p e e d ;  
 	 f l o a t   e l a p s e d T i m e ;  
  
 	 v o i d   S t a r t   ( )   {  
 	 	 x s p e e d   =   R a n d o m . R a n g e (   - S P E E D ,   S P E E D   ) ;  
 	 	 y s p e e d   =   R a n d o m . R a n g e (   - S P E E D ,   S P E E D   ) ;  
 	 	 z s p e e d   =   R a n d o m . R a n g e   ( - S P E E D ,   S P E E D ) ;  
 	 	 c o l   =   R a n d o m C o l o r ( ) ;  
 	 	 S e t C o l o r   ( ) ;  
 	 	 D e b u g . L o g   ( x s p e e d ) ;  
 	 }  
  
 	 v o i d   U p d a t e   ( )   {  
 	 	 e l a p s e d T i m e   + =   T i m e . d e l t a T i m e ;  
 	 	 t r a n s f o r m . p o s i t i o n   + =   n e w   V e c t o r 3 (  
 	 	 	 x s p e e d   *   T i m e . d e l t a T i m e ,    
 	 	 	 y s p e e d   *   T i m e . d e l t a T i m e ,    
 	 	 	 z s p e e d   *   T i m e . d e l t a T i m e  
 	 	 ) ;  
  
 	 	 t r a n s f o r m . R o t a t e ( V e c t o r 3 . r i g h t   *   T i m e . d e l t a T i m e ) ;  
 	 	 t r a n s f o r m . R o t a t e ( V e c t o r 3 . u p   *   T i m e . d e l t a T i m e ) ;  
  
 	 	 i f   ( e l a p s e d T i m e   > =   2 )  
 	 	 {  
 	 	 	 e l a p s e d T i m e   =   0 ;  
 	 	 	 c o l   =   R a n d o m C o l o r ( ) ;  
 	 	 	 S e t C o l o r   ( ) ;  
 	 	 }  
 	 }  
  
 	 v o i d   S e t C o l o r   ( )   {  
 	 	 G a m e O b j e c t [ ]   b o x e s   =   G a m e O b j e c t . F i n d G a m e O b j e c t s W i t h T a g ( " P l a y e r " ) ;  
 	 	 G a m e O b j e c t [ ]   l i g h t s   =   G a m e O b j e c t . F i n d G a m e O b j e c t s W i t h T a g ( " l i g h t S o u r c e " ) ;  
 	 	 i f   ( l i g h t s . L e n g t h   ! =   0 )   {  
 	 	 	 f o r   ( i n t   i   =   0 ;   i   <   l i g h t s . L e n g t h ;   i + + )   {  
 	 	 	 	 L i g h t   l i   =   l i g h t s   [ i ] . G e t C o m p o n e n t < L i g h t >   ( )   a s   L i g h t ;  
 	 	 	 	 l i . c o l o r   =   c o l ;  
 	 	 	 }  
 	 	 }  
 	 	 i f   ( b o x e s . L e n g t h   ! =   0 )   {  
 	 	 	 f o r   ( i n t   i   =   0 ;   i   <   b o x e s . L e n g t h ;   i + + )   {  
 	 	 	 	 R e n d e r e r   r e n d   =   b o x e s   [ i ] . G e t C o m p o n e n t < R e n d e r e r >   ( )   a s   R e n d e r e r ;  
 	 	 	 	 r e n d . m a t e r i a l . c o l o r   =   c o l ;  
 	 	 	 }  
 	 	 }  
 	 }  
  
 	 C o l o r   R a n d o m C o l o r ( )   {  
 	 	 r e t u r n   n e w   C o l o r ( R a n d o m . v a l u e ,   R a n d o m . v a l u e ,   R a n d o m . v a l u e ) ;  
 	 }  
 }  
 