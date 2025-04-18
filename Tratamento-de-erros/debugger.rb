puts "Digite o nome e sobrenome válido"
nome_completo = gets.to_s

require 'byebug'
debugger

if nome_completo =~ /[W|w]alter .*?[S|s]antos/
    puts "#{escreve_em_verde}Válido #{nome_completo}"
else
    puts "#{escreve_em_vermelho}Inválido #{nome_completo}"
end