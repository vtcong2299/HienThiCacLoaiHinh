using System;

namespace HienThiCacLoaiHinh
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            int i,j;
            
            Console.WriteLine("Ban muon ve hinh gi?");
           
            Console.WriteLine("1: Hinh Tam Giac");
            Console.WriteLine("2: Hinh Chu Nhat");
            Console.WriteLine("3: Hinh Vuong");
            Console.WriteLine("4: Hinh Tam Giac Nguoc");
            Console.WriteLine("5: Hinh Tam Giac Can");
            Console.WriteLine("6: Hinh Tam Giac Can Rong Ruot");
            Console.Write("Nhap so thu tu hinh ban muon ve: ");
            while(true)
            {
                if(Int32.TryParse(Console.ReadLine(),out choice)&&(choice==1 || choice==2 || choice==3 || choice==4 || choice==5 || choice==6))
                {                      
                    break;
                } 
                else
                {
                    Console.Write("Nhap so thu tu hinh ban muon ve: ");   
                }
                
            }  
            switch(choice)
            {
                case 1:
                {
                    int heightTamGiac;
                    

                    Console.WriteLine("[Nhap kich thuoc hinh Tam Giac muon ve]");
                    Console.Write("Nhap chieu cao: ");
                    while(true)
                    {
                        if(Int32.TryParse(Console.ReadLine(),out heightTamGiac))
                        {  
                            break;
                        } 
                        else
                        Console.WriteLine("Nhap lai chieu cao: ");   
                    }  
                    
                    i=0;
                                        
                    while(i<heightTamGiac)
                    {
                        j=0;
                        while(j<=i)
                        {
                            
                            Console.Write("*  ");  
                            j++;                             
                            
                        }
                        i++;
                        Console.Write(Environment.NewLine);
                    }
                    break;
                     
                }
                case 2:
                {
                    int lengthChuNhat;
                    int widthChuNhat;
                    Console.WriteLine("[Nhap kich thuoc hinh Tam Giac muon ve]");
                    Console.WriteLine("Nhap chieu dai: ");
                    while(true)
                    {
                        if(Int32.TryParse(Console.ReadLine(),out lengthChuNhat))
                        {  
                            break;
                        } 
                        else
                        Console.WriteLine("Nhap lai chieu dai: ");   
                    }  
                    Console.WriteLine("Nhap chieu rong: ");
                    while(true)
                    {
                        if(Int32.TryParse(Console.ReadLine(),out widthChuNhat))
                        {  
                            break;
                        } 
                        else
                        Console.WriteLine("Nhap lai chieu rong: ");   
                    } 
                    i=0;
                                        
                    while(i<widthChuNhat)
                    {
                        j=0;
                        while(j<lengthChuNhat)
                        {
                            
                            Console.Write("*  ");  
                            j++;                             
                            
                        }
                        i++;
                        Console.Write(Environment.NewLine);
                    }
                    break;
                }
                case 3:
                {
                    int lengthVuong;
                    

                    Console.WriteLine("[Nhap kich thuoc hinh Tam Giac muon ve]");
                    Console.Write("Nhap chieu dai canh: ");
                    while(true)
                    {
                        if(Int32.TryParse(Console.ReadLine(),out lengthVuong))
                        {  
                            break;
                        } 
                        else
                        Console.WriteLine("Nhap lai chieu dai canh: ");   
                    }  
                    
                    i=0;
                                        
                    while(i<lengthVuong)
                    {
                        j=0;
                        while(j<lengthVuong)
                        {
                            
                            Console.Write("*  ");  
                            j++;                             
                            
                        }
                        i++;
                        Console.Write(Environment.NewLine);
                    }
                    break;
                }
                case 4:
                {
                    int heightTamGiacNguoc;
                    

                    Console.WriteLine("[Nhap kich thuoc hinh Tam Giac Nguoc muon ve]");
                    Console.Write("Nhap chieu cao: ");
                    while(true)
                    {
                        if(Int32.TryParse(Console.ReadLine(),out heightTamGiacNguoc))
                        {  
                            break;
                        } 
                        else
                        Console.WriteLine("Nhap lai chieu cao: ");   
                    }  
                    
                    i=0;
                                        
                    while(i<heightTamGiacNguoc)
                    {
                        j=0;
                        while(j<(heightTamGiacNguoc-i))
                        {
                            
                            Console.Write("*  ");  
                            j++;                             
                            
                        }
                        i++;
                        Console.Write(Environment.NewLine);
                    }
                    break;
                }

                case 5:
                {
                    int heightTamGiacCan;
                    int spaces;

                    Console.WriteLine("[Nhap kich thuoc hinh Tam Giac Can muon ve]");
                    Console.Write("Nhap chieu cao: ");
                    while(true)
                    {
                        if(Int32.TryParse(Console.ReadLine(),out heightTamGiacCan))
                        {  
                            break;
                        } 
                        else
                        Console.WriteLine("Nhap lai chieu cao: ");   
                    }  
                    
                    i=0;
                                        
                    while(i<heightTamGiacCan)
                    {
                        spaces=0;
                        while(spaces<(heightTamGiacCan-i))
                        {
                            
                            Console.Write("   ");  
                            spaces++;                             
                            
                        }
                        j=0;
                        while(j<(2*i+1))
                        {
                            
                            Console.Write("*  ");  
                            j++;                             
                            
                        }
                        i++;
                        Console.Write(Environment.NewLine);
                    }
                    break;
                }
                case 6:
                {
                    int heightTamGiacCanRongRuot;
                    int spaces;

                    Console.WriteLine("[Nhap kich thuoc hinh Tam Giac Can Rong Ruot muon ve]");
                    Console.Write("Nhap chieu cao: ");
                    while(true)
                    {
                        if(Int32.TryParse(Console.ReadLine(),out heightTamGiacCanRongRuot))
                        {  
                            break;
                        } 
                        else
                        Console.WriteLine("Nhap lai chieu cao: ");   
                    }  
                    
                    i=1;
                                        
                    while(i<=heightTamGiacCanRongRuot)
                    {
                        spaces=0;
                        while(spaces<(heightTamGiacCanRongRuot-i))
                        {
                            
                            Console.Write("   ");  
                            spaces++;                             
                            
                        }
                        j=0;
                        int stars=(2*i)-1;
                        while(j<stars)
                        {
                            if (j==0 || j==stars-1|| i==heightTamGiacCanRongRuot)
                            {
                                Console.Write("*  ");  
                                
                            }
                            else
                            {
                                Console.Write("   ");
                            }
                            j++;                         
                            
                        }
                        i++;
                        Console.Write(Environment.NewLine);
                    }
                    break;
                }
            }
            
        }
    }
}