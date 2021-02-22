using System;
using System.Collections.Generic;
using System.Text;

namespace IBLL
{
    //抽象类
    public abstract class A_CRUD
    {
        //抽象方法
        public abstract int Add();
        //虚方法  重写
        public virtual void Close()
        { 
            //控制所有的关闭
        }
    }
}
