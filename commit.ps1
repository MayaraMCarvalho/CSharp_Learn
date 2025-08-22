[Console]::OutputEncoding = [System.Text.Encoding]::UTF8
Clear-Host

# Adiciona alterações ao Git
git add .

# Exibe o status do repositório
git status

# Define as cores equivalentes no PowerShell
$BPURPLE  = "Magenta"
$BYELLOW  = "Yellow"
$BGREEN   = "Green"
$BBLUE    = "Blue"
$BRED     = "Red"
$WHITE    = "White"

# Define as opções de commit
$commitTypes = @{
    1 = "feat"
    2 = "fix"
    3 = "docs"
    4 = "style"
    5 = "refactor"
    6 = "test"
    7 = "chore"
}

# Exibe opções coloridas
Write-Host "`nEscolha o tipo de commit:" -ForegroundColor $BPURPLE
Write-Host "1. " -NoNewline -ForegroundColor $BYELLOW
Write-Host "feat: " -NoNewline -ForegroundColor $WHITE
Write-Host "Adiciona nova feature na aplicação"

Write-Host "2. " -NoNewline -ForegroundColor $BYELLOW
Write-Host "fix: " -NoNewline -ForegroundColor $WHITE
Write-Host "Resolve um problema na aplicação"

Write-Host "3. " -NoNewline -ForegroundColor $BYELLOW
Write-Host "docs: " -NoNewline -ForegroundColor $WHITE
Write-Host "Alteração em documentação"

Write-Host "4. " -NoNewline -ForegroundColor $BYELLOW
Write-Host "style: " -NoNewline -ForegroundColor $WHITE
Write-Host "Formatação do código (indentação, espaços, etc)"

Write-Host "5. " -NoNewline -ForegroundColor $BYELLOW
Write-Host "refactor: " -NoNewline -ForegroundColor $WHITE
Write-Host "Refatoração de código sem mudança funcional"

Write-Host "6. " -NoNewline -ForegroundColor $BYELLOW
Write-Host "test: " -NoNewline -ForegroundColor $WHITE
Write-Host "Adição/Refatoração de testes"

Write-Host "7. " -NoNewline -ForegroundColor $BYELLOW
Write-Host "chore: " -NoNewline -ForegroundColor $WHITE
Write-Host "Ajustes em scripts de automação, CI/CD, etc"

# Captura a escolha do usuário
$choice = Read-Host "Digite o número correspondente"
if (-not $commitTypes.ContainsKey([int]$choice)) {
    Write-Host "Opção inválida" -ForegroundColor $BRED
    exit 1
}
$type = $commitTypes[[int]$choice]

# Solicita a mensagem do commit
Write-Host "`nInforme a mensagem de commit:" -ForegroundColor $BGREEN
$msg = Read-Host

# Confirma e executa o commit
Write-Host "`nExecutando commit..." -ForegroundColor $BBLUE
git commit -m "${type}: $msg"

# Mensagem de confirmação do commit
Write-Host "`nCommit realizado com sucesso!" -ForegroundColor $BGREEN

# Exibe o status do repositório após o commit
git status

# Pergunta se o usuário deseja subir as alterações
$pushChoice = Read-Host "`nDeseja subir as alterações para o repositório remoto? (s/n)"
$pushChoice = $pushChoice.ToLower()

if ($pushChoice -eq 's')
{
    Write-Host "`nSubindo alterações para o repositório remoto..." -ForegroundColor $BGREEN
    git push
    Write-Host "`nAlterações enviadas com sucesso!" -ForegroundColor $BBLUE
}
else
{
    Write-Host "`nAlterações não foram enviadas." -ForegroundColor $BYELLOW
}
