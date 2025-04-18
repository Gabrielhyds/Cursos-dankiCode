puts "Digite um telefone valido: "

telefone = gets.to_s


# Códigos ANSI para cores
RED = "\e[31m"
GREEN = "\e[32m"
RESET = "\e[0m"

if telefone  =~ /^(\+55\s?)?(\(?\d{2}\)?)?\s?\d{4,5}-?\d{4}$/
    puts "#{GREEN}telefone VALIDO #{telefone}#{RESET}"
else
    puts "#{RED}Telefone não EXISTE #{telefone}#{RESET}"
end