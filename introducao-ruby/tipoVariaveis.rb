#ruby é uma linguagem dinamicamente tipada

#exemplo 

#atribui a variavel o valor 1 sem declarar o tipo
var = 1;

#imprime o tipo da variavel .class
puts var.class;
#puts 1.class;

#erro: concatenar inteiro com string | precisa converter
c = var + "10".to_i; #to_i => converte a string para inteiro


puts 1.class; #int

puts 1.1.class; #float

puts true.class; #bool

puts false.class; #bool

puts "".class; #string 

puts :teste.class; #symbol

x = {teste:'ss'}; #hash
puts x.class; #hash

puts [].class; #array

puts (1..2).class; #range