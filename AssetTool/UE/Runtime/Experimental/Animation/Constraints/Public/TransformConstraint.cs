namespace AssetTool
{
    [JsonAsset("TickableTransformConstraint")]
    public class UTickableTransformConstraint : UTickableConstraint
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TickableTranslationConstraint")]
    public class UTickableTranslationConstraint : UTickableTransformConstraint
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TickableRotationConstraint")]
    public class UTickableRotationConstraint : UTickableTransformConstraint
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TickableScaleConstraint")]
    public class UTickableScaleConstraint : UTickableTransformConstraint
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TickableParentConstraint")]
    public class UTickableParentConstraint : UTickableTransformConstraint
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TickableLookAtConstraint")]
    public class UTickableLookAtConstraint : UTickableTransformConstraint
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}