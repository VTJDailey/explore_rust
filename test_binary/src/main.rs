pub mod secondary;

fn main() {
    let n = test();
    println!("Hello, world! {n}");

    let mut s = String::from("Test Str");
    s.push_str(", and more");

    for x in 1..=4{
        let result = nested(dbg!(x));
        println!("the num is {result}");
    }

    let mut v:Vec<i32> = Vec::new();
    v.push(23);
    fn nested(n: i32) -> i32{
        n + 10
    }
    

    let sec = crate::secondary::secondary(55);
    println!("secondary is {sec}");

    let final_output = format!("n={n}, s={s}, sec={sec}, lenv={v:?}");

    println!("{final_output}");
}

fn test() -> i32{
    5
}