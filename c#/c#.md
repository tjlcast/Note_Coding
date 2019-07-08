# C#

## Syntax

### pro_1
- 在C#中，Mapping 为 Hashtable
    + Hashtable()[]
    + Hashtable().Add(k, v)
- 在C#中，基础类型也是object的子类 
    + int num = (int) ht[key] // (k, v) is (obj, obj)
- 数组的长度获取：
    + int len = int[3]{1, 2, 3}.Length

### pro_3
- 貌似在c#中，没有范型
- 在C#中，函数都是大写首字母
    + "".Equals()
- 在leetcode上，避免使用类的static property, 这种成员变量会被上次执行的结果影响.
