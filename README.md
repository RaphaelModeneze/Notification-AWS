# Notification-AWS


# AWS S3 to AWS SQS 

1. Executar command line, use o AWS SAM para criar e implantar os recursos da AWS para o padrão conforme especificado no arquivo template.yml:
    ```
    sam build
    sam deploy --guided
    ```

2. Configurar variáveis de ambiente para o usuário padrão.
    Conforme o exemplo a seguir
    ```
    setx AWS_ACCESS_KEY_ID AKIAIOSFODNN7EXAMPLE
    setx AWS_SECRET_ACCESS_KEY wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY
    setx AWS_DEFAULT_REGION us-west-2
    ```
    
 3. Instalar a extensão 'AWS ToolKit for Visual Studio'

![image](https://user-images.githubusercontent.com/22237907/201748907-0a9a1a3f-76f7-4c05-9d1d-1b7e0ec96812.png)

