import { MetroStationTemplatePage } from './app.po';

describe('MetroStation App', function() {
  let page: MetroStationTemplatePage;

  beforeEach(() => {
    page = new MetroStationTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
