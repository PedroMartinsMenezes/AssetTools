namespace AssetTool
{
    [JsonAsset("LidarEditorToolBase")]
    public class ULidarEditorToolBase : UInteractiveTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarEditorToolBuilderBase")]
    public class ULidarEditorToolBuilderBase : UInteractiveToolWithToolTargetsBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarEditorToolClickDragBase")]
    public class ULidarEditorToolClickDragBase : ULidarEditorToolBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarEditorToolBuilderSelect")]
    public class ULidarEditorToolBuilderSelect : ULidarEditorToolBuilderBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarToolActionsAlign")]
    public class ULidarToolActionsAlign : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarEditorToolAlign")]
    public class ULidarEditorToolAlign : ULidarEditorToolBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarEditorToolBuilderAlign")]
    public class ULidarEditorToolBuilderAlign : ULidarEditorToolBuilderBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarToolActionsMerge")]
    public class ULidarToolActionsMerge : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarEditorToolMerge")]
    public class ULidarEditorToolMerge : ULidarEditorToolBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarEditorToolBuilderMerge")]
    public class ULidarEditorToolBuilderMerge : ULidarEditorToolBuilderBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarToolActionsCollision")]
    public class ULidarToolActionsCollision : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarEditorToolCollision")]
    public class ULidarEditorToolCollision : ULidarEditorToolBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarEditorToolBuilderCollision")]
    public class ULidarEditorToolBuilderCollision : ULidarEditorToolBuilderBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarToolActionsMeshing")]
    public class ULidarToolActionsMeshing : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarEditorToolMeshing")]
    public class ULidarEditorToolMeshing : ULidarEditorToolBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarEditorToolBuilderMeshing")]
    public class ULidarEditorToolBuilderMeshing : ULidarEditorToolBuilderBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarToolActionsNormals")]
    public class ULidarToolActionsNormals : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarEditorToolNormals")]
    public class ULidarEditorToolNormals : ULidarEditorToolBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarEditorToolBuilderNormals")]
    public class ULidarEditorToolBuilderNormals : ULidarEditorToolBuilderBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarToolActionsSelection")]
    public class ULidarToolActionsSelection : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarEditorToolSelectionBase")]
    public class ULidarEditorToolSelectionBase : ULidarEditorToolClickDragBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarEditorToolBoxSelection")]
    public class ULidarEditorToolBoxSelection : ULidarEditorToolSelectionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarEditorToolBuilderBoxSelection")]
    public class ULidarEditorToolBuilderBoxSelection : ULidarEditorToolBuilderBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarEditorToolPolygonalSelection")]
    public class ULidarEditorToolPolygonalSelection : ULidarEditorToolSelectionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarEditorToolBuilderPolygonalSelection")]
    public class ULidarEditorToolBuilderPolygonalSelection : ULidarEditorToolBuilderBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarEditorToolLassoSelection")]
    public class ULidarEditorToolLassoSelection : ULidarEditorToolSelectionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarEditorToolBuilderLassoSelection")]
    public class ULidarEditorToolBuilderLassoSelection : ULidarEditorToolBuilderBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarToolActionsPaintSelection")]
    public class ULidarToolActionsPaintSelection : ULidarToolActionsSelection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarEditorToolPaintSelection")]
    public class ULidarEditorToolPaintSelection : ULidarEditorToolSelectionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LidarEditorToolBuilderPaintSelection")]
    public class ULidarEditorToolBuilderPaintSelection : ULidarEditorToolBuilderBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}