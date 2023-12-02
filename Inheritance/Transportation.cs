using System;
namespace Inheritance
{
    //抽象类 不能创建对象 可能有抽象方法或抽象成员
	public abstract class Transportation
	{
        public string Type { get; set; }

        //抽象函数子类必须重写实现
        public abstract void Transport();


        //虚方法可以写方法体 可以实现 也可以部分实现 子类可以选择是否实现
        //public virtual void Transport(){};

    }
}

