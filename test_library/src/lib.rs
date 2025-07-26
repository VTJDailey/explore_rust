pub fn add_five(left: u64) -> u64 {
    left + 5
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn five_works() {
        let result = add_five(1023);
        assert_eq!(result, 1028);
    }


    #[test]
    fn bad_terst() {
        let result = add_five(1023);
        assert_eq!(result, 1029);
    }
    #[test]
    fn five_worksa() {
        let result = add_five(1023);
        assert_eq!(result, 1028);
    }
    #[test]
    fn five_worksb() {
        let result = add_five(1023);
        assert_eq!(result, 1028);
    }


}
