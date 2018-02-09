Coding question 1:

Build a function, `morse_encode(str)` that takes in a string (no
 numbers or punctuation) and outputs the morse code for it. See
 http://en.wikipedia.org/wiki/Morse_code. Put two spaces between
 words and one space between letters.

 You'll have to type in morse code: I'd use a hash to map letters to
 codes. Don't worry about numbers.
 
 
MORSE_CODE = {
  "a" => ".-",  "b" => "-...",  "c" => "-.-.",  "d" => "-..",  "e" => ".",  "f" => "..-.",  "g" => "--.",  "h" => "....",
  "i" => "..",  "j" => ".---",  "k" => "-.-",  "l" => ".-..",  "m" => "--",  "n" => "-.",  "o" => "---",  "p" => ".--.",
  "q" => "--.-",  "r" => ".-.",  "s" => "...",  "t" => "-",  "u" => "..-",  "v" => "...-",  "w" => ".--",  "x" => "-..-",
  "y" => "-.--",  "z" => "--.."
}


Please encode: “cat in hat”
Please write unit tests for this task
Could it be more efficient?
