// 事件的拥有者【类】
// 事件
// 事件的响应者【类】
// 事件处理器(委托 定义的一个 字段)(用于 存储 是谁订阅了事件)(这个也是在事件的拥有者中定义的)
// 订阅关系

enum Name{Coffee,Tea,Juice}
enum Size{Small,Medium,Large}

public delegate void OrderEventHandler(Customer _customer,OrderEventArgs _e);//委托类型的声明

public class Customer{//事件的拥有者
    private OrderEventHandler orderEventHandler;//事件管理器
    public event OrderEventHandler OrderEvent{
        add{
            orderEventHandler+=value;
        }
        remove{
            orderEventHandler-=value;
        }
    }
    public void order(OrderEventArgs e){//事件的触发者 应当保证只能够由事件的拥有者来触发
        if(orderEventHandler!=null&&e!=null){
            orderEventHandler(this,e);
        }
    
    }

}
public class OrderEventArgs:EventArgs{
    public string drinkName=null;
    public string drinkSize=null;
}

public class Waiter{
    public void TakeAction(Customer _customer,OrderEventArgs _e){
        int totalPrices=0;

        switch(_e.drinkSize){
            case "Small":
                totalPrices+=10;
                break;
            case "Medium":
                totalPrices+=15;
                break;
            case "Large":
                totalPrices+=20;
                break;
        }
        Console.WriteLine("你好，你要的{0}已经准备好了:{1}",_e.drinkName,_customer.ToString());
        Console.WriteLine("好的，你需要付{0}元",totalPrices);
    }
}

public class Program{
    public static void Main(string[] args){
        Customer customer1=new Customer();
        Customer customer2=new Customer();
        Waiter waiter=new Waiter();
        customer1.OrderEvent+=new OrderEventHandler(waiter.TakeAction);//订阅事件的关系 +=
        customer2.OrderEvent+=new OrderEventHandler(waiter.TakeAction);
        OrderEventArgs e1=new OrderEventArgs(); 
        e1.drinkName="Coffee";
        e1.drinkSize="Large";
        OrderEventArgs e2=new OrderEventArgs();
        e2.drinkName="Tea";
        e2.drinkSize="Medium";
        customer1.order(e1);
        customer2.order(e2);
    }
}