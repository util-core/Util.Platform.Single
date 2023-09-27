import { Component, OnInit, ChangeDetectionStrategy, ChangeDetectorRef, Input, Output, EventEmitter, AfterViewInit, inject, DestroyRef } from '@angular/core';
import { takeUntilDestroyed } from '@angular/core/rxjs-interop';
import { Subject } from 'rxjs';
import { debounceTime, distinctUntilChanged } from 'rxjs/operators';

import {fnKebabCase} from "./camelFn";
import {zorroIcons} from "./zorro-icons";

interface IconItem {
  icon: string;
  isChecked: boolean;
}

@Component({
  selector: 'app-icon-select',
  templateUrl: './icon-select.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class IconSelectComponent implements OnInit, AfterViewInit {
  @Input() visible = false;
  // @Input() rows = 20;
  @Input() columns = 5;
  @Input() pageSize = 100;
  cardWidth = 350;
  cardHeight = 270;
  iconSpan = 20;
  // 做图标搜索防抖
  private searchText$ = new Subject<string>();
  @Input() selectedIcon = '';
  @Output() readonly selectIcon = new EventEmitter<string>();
  // 分页信息
  pageObj = {
    pageSize: 100,
    pageNum: 1
  };
  // 图标搜索出来的所有结果
  iconsStrAllArray: IconItem[] = [];
  sourceIconsArray: IconItem[] = []; // 所有icon的数据源
  iconsStrShowArray: IconItem[] = []; // 每页中展示的icon
  gridStyle = {
    width: this.iconSpan +'%'
  };
  destroyRef = inject(DestroyRef);

  constructor(private cdr: ChangeDetectorRef) {
    zorroIcons.forEach(item => {
      this.sourceIconsArray.push({ icon: fnKebabCase(item), isChecked: false });
    });
    this.iconsStrAllArray = JSON.parse(JSON.stringify(this.sourceIconsArray));
  }

  searchIcon(e: Event): void {
    this.searchText$.next((e.target as HTMLInputElement).value);
  }

  selIconFn(item: IconItem): void {
    this.selectedIcon = item.icon;
    this.sourceIconsArray.forEach(icon => (icon.isChecked = false));
    this.iconsStrShowArray.forEach(icon => (icon.isChecked = false));
    this.iconsStrAllArray.forEach(icon => (icon.isChecked = false));

    item.isChecked = true;
    this.visible = false;
    this.selectIcon.emit(item.icon);
  }

  pageSizeChange(event: number): void {
    this.pageObj = { ...this.pageObj, pageSize: event };
    this.getData(1);
  }

  // 分页获取数据
  getData(event: number = this.pageObj.pageNum): void {
    this.pageObj = { ...this.pageObj, pageNum: event };
    this.iconsStrShowArray = [...this.iconsStrAllArray.slice((this.pageObj.pageNum - 1) * this.pageObj.pageSize, this.pageObj.pageNum * this.pageObj.pageSize)];
    this.cdr.markForCheck();
  }

  ngOnInit(): void {
    this.cardWidth = 66.8 * this.columns;
    this.cardHeight = (71.5 * (this.pageSize / this.columns)) * 0.4;
    this.iconSpan = (100 / this.columns);
    this.pageObj.pageSize = this.pageSize;
    this.getData();
  }

  ngAfterViewInit(): void {
    this.searchText$.pipe(debounceTime(200), distinctUntilChanged(), takeUntilDestroyed(this.destroyRef)).subscribe(res => {
      this.iconsStrAllArray = this.sourceIconsArray.filter(item => item.icon.includes(res));
      this.getData();
      this.cdr.markForCheck();
    });
  }
}
