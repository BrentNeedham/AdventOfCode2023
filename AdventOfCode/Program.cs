using AoCHelper;

await Solver.SolveAll(opt =>
{
    opt.ShowConstructorElapsedTime = true;
    opt.ShowTotalElapsedTimePerDay = true;
    opt.ElapsedTimeFormatSpecifier = "F3";
});
