namespace AssetTool
{
    [TransferibleStruct("MaterialOverrideNanite")]
    public class FMaterialOverrideNanite : ITransferible
    {
        public UInt32 OverrideMaterialRef;
        public FBool bEnableOverride;
        public UInt32 OverrideMaterial;
        public FBool bSerializeAsCookedData;
        public UInt32 OverrideMaterialEditor;

        public ITransferible Move2(Transfer transfer)
        {
            if (!transfer.Supports.NaniteMaterialOverrideUsesEditorOnly)
            {
                transfer.Move(ref OverrideMaterialRef);
                transfer.Move(ref bEnableOverride);
                transfer.Move(ref OverrideMaterial);
                return this;
            }
            transfer.Move(ref bSerializeAsCookedData);
            if (bSerializeAsCookedData)
            {
                transfer.Move(ref OverrideMaterialEditor);
                transfer.Move(ref OverrideMaterial);
            }
            return null;
        }
    }
}