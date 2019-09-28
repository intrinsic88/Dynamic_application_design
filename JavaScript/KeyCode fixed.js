class KeyCode {
    static getKeyMap(keycode) {
        let code = {37:"{Left}", 38:"{Up}", 39:"{right}", 40:"down"};
        return code[keycode];
    }
}

module.exports = {
    KeyCode
}