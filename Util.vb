Imports TaleWorlds.Library

Public Module Util
    Public Sub Print(s As String, Optional colour As Color = Nothing)
        If IsNothing(colour) Then colour = Color.White
        InformationManager.DisplayMessage(New InformationMessage(s, colour))
    End Sub
End Module
