#programa que solicita ao user um numero e ele retorna
# o tipo de dado daquele numero

puts "Digite um numero inteiro:"
var = gets.to_i;
puts "Este é um tipo de dado: #{var.class}" 

puts "Digite um numero float:"
var = gets.to_f;
puts "Este é um tipo de dado: #{var.class}" 

puts "Digite um texto:"
var = gets.to_s;
puts "Este é um tipo de dado: #{var.class}" 

puts "É isso obrigado!"