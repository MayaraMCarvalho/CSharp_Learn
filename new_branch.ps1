# Definir variáveis
$DEV_BRANCH = "main" # Substitua pelo nome da sua branch de desenvolvimento
$BRANCH_FILE = "branch.txt" # Arquivo para salvar o nome da nova branch

# Fazer checkout na branch de desenvolvimento
Write-Host "Fazendo checkout na branch $DEV_BRANCH..."
git checkout $DEV_BRANCH

# Fazer pull da branch de desenvolvimento
Write-Host "Atualizando branch $DEV_BRANCH..."
git pull origin $DEV_BRANCH

# Solicitar o nome da nova branch
Write-Host "Digite o nome da nova branch:"
$branch_name = Read-Host
$feature_branch = "feature/$branch_name"

Write-Host "Nova branch: $feature_branch"

# Salvar nome da branch em um arquivo
Set-Content -Path $BRANCH_FILE -Value $feature_branch
Write-Host "Branch salva em $BRANCH_FILE."

# Criar a nova branch
Write-Host "Criando nova branch..."
git checkout -b (Get-Content $BRANCH_FILE)

# Fazer push da nova branch para o repositório remoto
Write-Host "Definindo upstream da nova branch..."
git push --set-upstream origin (Get-Content $BRANCH_FILE)

Write-Host "Branch $feature_branch criada e configurada com sucesso!"