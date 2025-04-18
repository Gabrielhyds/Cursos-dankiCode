puts "digite um numero: "

var = gets.to_i

if(var == 1) 
    puts "isso ai cara o valor era esse mesmo #{var}";
elsif var == 2
    puts "isso ai cara o valor era esse mesmo #{var}";
else
    puts  "tente di novo"
end 


#puts "isso ai cara o valor era esse mesmo #{var}" if(var == 1) 

#EXEMPLO DE SWITCH CASE

# puts "Escolha uma opção:"
# puts "1 - Dizer Olá"
# puts "2 - Exibir a data e hora atuais"
# puts "3 - Listar arquivos no diretório atual"
# puts "4 - Sair"

# print "Digite a sua escolha [1-4]: "
# escolha = gets.chomp.to_i

# case escolha
# when 1
#   puts "Olá!"
# when 2
#   puts "A data e hora atuais são: #{Time.now}"
# when 3
#   puts "Arquivos no diretório atual:"
#   puts Dir.entries(".")
# when 4
#   puts "Saindo..."
#   exit
# else
#   puts "Escolha inválida, por favor, tente novamente."
# end