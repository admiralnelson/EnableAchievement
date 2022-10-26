Imports System.Reflection
Imports HarmonyLib
Imports StoryMode.GameComponents.CampaignBehaviors
Imports TaleWorlds.CampaignSystem
Imports TaleWorlds.Core
Imports TaleWorlds.MountAndBlade

Namespace Global.EnableAchievement
    Public Class EntryPoint
        Inherits MBSubModuleBase
        Protected Overrides Sub OnSubModuleLoad()
            MyBase.OnSubModuleLoad()
            Dim har As New Harmony("org.calradia.admiralnelson.enableachievement")
            har.PatchAll()
        End Sub

        Protected Overrides Sub OnGameStart(game As Game, gameStarterObject As IGameStarter)
            MyBase.OnGameStart(game, gameStarterObject)
            If IsNothing(game) Then
                Exit Sub
            End If

            DoIt(gameStarterObject)

        End Sub
    End Class

End Namespace