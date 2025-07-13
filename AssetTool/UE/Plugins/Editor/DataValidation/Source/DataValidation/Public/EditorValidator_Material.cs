namespace AssetTool
{
    [JsonAsset("EditorValidator_Material")]
    public class UEditorValidator_Material : UEditorValidatorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ValidationMaterial")]
    public class UValidationMaterial : UMaterial
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}